﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using RascalApp.Models;

namespace RascalApp
{
    public class Funcionalidades
    {
        public static string MD5Hash(string text)
        {
            MD5 md5 = new MD5CryptoServiceProvider();

            //compute hash from the bytes of text  
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));

            //get hash result after compute it  
            byte[] result = md5.Hash;

            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                //change it into 2 hexadecimal digits  
                //for each byte  
                strBuilder.Append(result[i].ToString("x2"));
            }

            return strBuilder.ToString();
        }

        public static byte[] GetImageAsByteArray(string urlImage)
        {
            return File.ReadAllBytes(urlImage);
        }

        public static string RemoveSpecialCharacters(string str)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in str)
            {
                if ((c >= '0' && c <= '9') || (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || c == '.' || c == '_')
                {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }

        public static string RemoveWhitespace(string input)
        {
            return new string(input.ToCharArray()
                .Where(c => !Char.IsWhiteSpace(c))
                .ToArray());
        }

        public static bool EqualsUpToSeconds(DateTime dt1, DateTime dt2)
        {
            return dt1.Year == dt2.Year && dt1.Month == dt2.Month && dt1.Day == dt2.Day &&
                   dt1.Hour == dt2.Hour && dt1.Minute == dt2.Minute && dt1.Second == dt2.Second;
        }

        public static string TitleStyle(string str)
        {
            return System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str.ToLower());
        }

        //MODELO
        public static void GuardarNovoModelo(string Nome, string caminhoFoto)
        {
            OleDbConnection _connection = new OleDbConnection();
            _connection.ConnectionString = ConfigurationManager.ConnectionStrings["BDRascalconnectionString"].ToString();
            _connection.Open();

            //Inserir novo modelo
            OleDbCommand _command = new OleDbCommand();
            _command.Connection = _connection;
            _command.CommandType = CommandType.Text;
            _command.CommandText = "INSERT INTO Modelo (Nome, CaminhoFoto, DateCreated) VALUES ('" + TitleStyle(Nome) + "', '" + caminhoFoto + "', '" + DateTime.Now +"')";
            _command.ExecuteNonQuery();

            _connection.Close();
        }

        public static List<Modelo> BuscarModelos()
        {
            List<Modelo> listaModelos = new List<Modelo>();

            CultureInfo PTCultureInfo = new CultureInfo("pt-PT");

            OleDbConnection _connection = new OleDbConnection();
            _connection.ConnectionString = ConfigurationManager.ConnectionStrings["BDRascalconnectionString"].ToString();

            try
            {
                _connection.Open();
                OleDbCommand cmd = new OleDbCommand("SELECT * FROM Modelo", _connection);

                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    listaModelos.Add(new Modelo
                    {
                        ID = Convert.ToInt32(reader.GetValue(0)),
                        Nome = reader.GetString(1),
                        CaminhoFoto = reader.GetString(2),
                        DateCreated = DateTime.Parse(reader.GetValue(3).ToString(), PTCultureInfo),
                        Visualizacoes = Convert.ToInt32(reader.GetValue(4))
                    });
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
            finally
            {
                _connection.Close();
            }

            return listaModelos;
        }

        public static Modelo BuscarModelo(int _ID)
        {
            List<Modelo> listaGalerias = new List<Modelo>();

            CultureInfo PTCultureInfo = new CultureInfo("pt-PT");

            OleDbConnection _connection = new OleDbConnection();
            _connection.ConnectionString = ConfigurationManager.ConnectionStrings["BDRascalconnectionString"].ToString();

            try
            {
                _connection.Open();
                OleDbCommand cmd = new OleDbCommand("SELECT * FROM Modelo WHERE ID=" + _ID, _connection);

                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    listaGalerias.Add(new Modelo
                    {
                        ID = Convert.ToInt32(reader.GetValue(0)),
                        Nome = reader.GetString(1),
                        CaminhoFoto = reader.GetString(2),                        
                        DateCreated = DateTime.Parse(reader.GetValue(3).ToString(), PTCultureInfo),
                        Visualizacoes = Convert.ToInt32(reader.GetValue(4)),
                    });
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine(ex.Message);
                return null;
            }
            finally
            {
                _connection.Close();
            }

            return listaGalerias.FirstOrDefault();
        }

        public static void EditarModelo(string NNome, string NcaminhoFoto, Modelo _este)
        {
            string NovoCaminho = "nada";

            //Se for para atualizar a foto
            if (NcaminhoFoto != _este.CaminhoFoto)
            {
                //apagar foto
                File.Delete(_este.CaminhoFoto);

                //Guardar nova foto
                string[] parts = NcaminhoFoto.Split('\\');
                string[] Nomes = parts[parts.Count() - 1].Split('.');

                NovoCaminho = "E:\\Rascal\\Modelos\\" + RemoveWhitespace(RemoveSpecialCharacters(_este.Nome)) + "\\FotoDela." + Nomes[1];
                File.Move(NcaminhoFoto, NovoCaminho);

                NcaminhoFoto = NovoCaminho;
            }

            //Se for para atualizar o Nome
            if (NNome != _este.Nome)
            {
                string novoCa = "E:\\Rascal\\Modelos\\" + Funcionalidades.RemoveWhitespace(Funcionalidades.RemoveSpecialCharacters(NNome));
                Directory.CreateDirectory(novoCa);

                MudarSitioGalerias(novoCa, NNome, _este);

                //Atualizar foto
                string[] parts = _este.CaminhoFoto.Split('\\');
                string[] Nomes = parts[parts.Count() - 1].Split('.');

                NovoCaminho = "E:\\Rascal\\Modelos\\" + RemoveWhitespace(RemoveSpecialCharacters(NNome)) + "\\FotoDela." + Nomes[1];
                File.Move(NcaminhoFoto, NovoCaminho);

                //Apagar diretorio antigo
                Directory.Delete("E:\\Rascal\\Modelos\\" + RemoveWhitespace(RemoveSpecialCharacters(_este.Nome)), true);
            }

            if (NovoCaminho == "nada")
                NovoCaminho = _este.CaminhoFoto;

            OleDbConnection _connection = new OleDbConnection();
            _connection.ConnectionString = ConfigurationManager.ConnectionStrings["BDRascalconnectionString"].ToString();
            _connection.Open();

            //Inserir novo modelo
            OleDbCommand _command = new OleDbCommand();
            _command.Connection = _connection;
            _command.CommandType = CommandType.Text;
            _command.CommandText = "UPDATE Modelo SET Nome='" + TitleStyle(NNome) + "', CaminhoFoto='" + NovoCaminho + "' WHERE ID=" + _este.ID;
            _command.ExecuteNonQuery();

            _connection.Close();            
        }

        public static void MudarSitioGalerias(string novoCaminho, string NNome, Modelo _esta)
        {
            List<Galeria> GaleriasDela = BuscarGaleriasDELA(_esta.ID);
            List<Foto> Fotos = BuscarFotos();

            foreach(Galeria glr in GaleriasDela)
            {                
                foreach(Foto ft in Fotos)
                {
                    if(ft.IdGaleria == glr.ID)
                    {
                        string[] Nome = ft.CaminhoFoto.Split('\\');

                        //Diretorio da galeria
                        if (!Directory.Exists(novoCaminho + "\\" + Nome[Nome.Count() - 2]))
                            Directory.CreateDirectory(novoCaminho + "\\" + Nome[Nome.Count() - 2]);
                        
                        //Editar Registo
                        EditarFoto(novoCaminho + "\\" + Nome[Nome.Count() - 2] + "\\" + Nome[Nome.Count() - 1], ft.ID);

                        //Mover foto
                        File.Move(ft.CaminhoFoto, novoCaminho + "\\" + Nome[Nome.Count() - 2] + "\\" + Nome[Nome.Count() - 1]);
                    }
                }                
            }
        }

        public static void EliminarModelo(Modelo _este)
        {
            //apagar registos de fotos e galerias
            foreach(Galeria glr in BuscarGalerias().ToList())
            {
                if(glr.Identificador == _este.ID)
                {
                    //apagar fotos
                    foreach(Foto ft in BuscarFotos().ToList())
                    {
                        if (ft.IdGaleria == glr.ID)
                            EliminarFoto(ft);
                    }

                    //apagar galeria
                    string caminho = "E:\\Rascal\\Modelos\\" + RemoveWhitespace(RemoveSpecialCharacters(_este.Nome)) + "\\" + glr.Designacao;
                    EliminarGaleria(caminho, glr.ID);
                }
            }


            OleDbConnection _connection = new OleDbConnection();
            _connection.ConnectionString = ConfigurationManager.ConnectionStrings["BDRascalconnectionString"].ToString();
            _connection.Open();

            //Apagar modelo
            OleDbCommand _command = new OleDbCommand();
            _command.Connection = _connection;
            _command.CommandType = CommandType.Text;
            _command.CommandText = "DELETE FROM Modelo WHERE ID=" + _este.ID;
            _command.ExecuteNonQuery();

            _connection.Close();            
        }

        public static void AumentarModeloVisu(int _ID, int visus)
        {
            OleDbConnection _connection = new OleDbConnection();
            _connection.ConnectionString = ConfigurationManager.ConnectionStrings["BDRascalconnectionString"].ToString();
            _connection.Open();

            //Inserir novo modelo
            OleDbCommand _command = new OleDbCommand();
            _command.Connection = _connection;
            _command.CommandType = CommandType.Text;
            _command.CommandText = "UPDATE Modelo SET Visualizacoes=" + visus + " WHERE ID=" + _ID;
            _command.ExecuteNonQuery();

            _connection.Close();
        }

        //CLUBE
        public static void GuardarNovoClube(string Nome, string NomeFoto)
        {
            OleDbConnection _connection = new OleDbConnection();
            _connection.ConnectionString = ConfigurationManager.ConnectionStrings["BDRascalconnectionString"].ToString();
            _connection.Open();

            //Inserir novo modelo
            OleDbCommand _command = new OleDbCommand();
            _command.Connection = _connection;
            _command.CommandType = CommandType.Text;
            _command.CommandText = "INSERT INTO Clube (Nome, NomeFoto, DateCreated) VALUES (@nomedele, '" + TitleStyle(NomeFoto) + "', '" + DateTime.Now + "')";
            _command.Parameters.Add("@nomedele", OleDbType.VarWChar).Value = TitleStyle(Nome);
            _command.ExecuteNonQuery();

            _connection.Close();
        }

        public static void EditarClube(string NNome, string NNomeFoto, Clube _este)
        {
            string[] parts = NNomeFoto.Split('.');
            string[] parts2 = _este.NomeFoto.Split('.');

            string NovoCaminhoFoto = NNomeFoto;

            //Verificacao 'nop'
            if (NNome == "nop")
                NNome = _este.Nome;

            if (NNomeFoto == "nop")
                NNomeFoto = RemoveWhitespace(RemoveSpecialCharacters(NNome)) + "." + parts2[parts2.Count() - 1];
            else
                NNomeFoto = RemoveWhitespace(RemoveSpecialCharacters(NNome)) + "." + parts[parts.Count() - 1];

            OleDbConnection _connection = new OleDbConnection();
            _connection.ConnectionString = ConfigurationManager.ConnectionStrings["BDRascalconnectionString"].ToString();
            _connection.Open();

            //Inserir novo clube
            OleDbCommand _command = new OleDbCommand();
            _command.Connection = _connection;
            _command.CommandType = CommandType.Text;
            _command.CommandText = "UPDATE Clube SET Nome=@nomedele, NomeFoto='" + NNomeFoto + "' WHERE ID=" + _este.ID;
            _command.Parameters.Add("@nomedele", OleDbType.VarWChar).Value = TitleStyle(NNome);
            _command.ExecuteNonQuery();

            _connection.Close();

            //Se for para atualizar a foto
            if(NovoCaminhoFoto != "nop")
            {
                //apagar foto
                File.Delete("E:\\Rascal\\Clubes\\" + _este.NomeFoto);

                //Guardar nova foto
                string NovaFoto = "E:\\Rascal\\Clubes\\" + NNomeFoto;
                File.Move(NovoCaminhoFoto, NovaFoto);
            } 
            else
            {
                //Atualizar nome da foto existente
                File.Move("E:\\Rascal\\Clubes\\" + _este.NomeFoto, "E:\\Rascal\\Clubes\\" + NNomeFoto);
            }
        }

        public static List<Clube> BuscarClubes()
        {
            List<Clube> listClubes = new List<Clube>();

            CultureInfo PTCultureInfo = new CultureInfo("pt-PT");

            OleDbConnection _connection = new OleDbConnection();
            _connection.ConnectionString = ConfigurationManager.ConnectionStrings["BDRascalconnectionString"].ToString();

            try
            {
                _connection.Open();
                OleDbCommand cmd = new OleDbCommand("SELECT * FROM Clube", _connection);

                OleDbDataReader reader = cmd.ExecuteReader();

                while(reader.Read())
                {                   
                    listClubes.Add(new Clube
                    {
                        ID = Convert.ToInt32(reader.GetValue(0)),
                        Nome = reader.GetString(1),
                        NomeFoto = reader.GetString(2),
                        DateCreated = DateTime.Parse(reader.GetValue(3).ToString(), PTCultureInfo)
                    });
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
            finally
            {
                _connection.Close();
            }

            return listClubes;
        }

        public static Clube BuscarClube(int _ID)
        {
            List<Clube> listClubes = new List<Clube>();

            CultureInfo PTCultureInfo = new CultureInfo("pt-PT");

            OleDbConnection _connection = new OleDbConnection();
            _connection.ConnectionString = ConfigurationManager.ConnectionStrings["BDRascalconnectionString"].ToString();

            try
            {
                _connection.Open();
                OleDbCommand cmd = new OleDbCommand("SELECT * FROM Clube WHERE ID=" + _ID, _connection);

                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    listClubes.Add(new Clube
                    {
                        ID = Convert.ToInt32(reader.GetValue(0)),
                        Nome = reader.GetString(1),
                        NomeFoto = reader.GetString(2),
                        DateCreated = DateTime.Parse(reader.GetValue(3).ToString(), PTCultureInfo)
                    });
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
            finally
            {
                _connection.Close();
            }

            return listClubes.FirstOrDefault();
        }

        public static void EliminarTodosClubes()
        {            
            OleDbConnection _connection = new OleDbConnection();
            _connection.ConnectionString = ConfigurationManager.ConnectionStrings["BDRascalconnectionString"].ToString();
            _connection.Open();

            //Inserir novo modelo
            OleDbCommand _command = new OleDbCommand();
            _command.Connection = _connection;
            _command.CommandType = CommandType.Text;
            _command.CommandText = "DELETE FROM Clube";
            _command.ExecuteNonQuery();

            _connection.Close();

            string[] IMGfiles = Directory.GetFiles("E:\\Rascal\\Clubes");

            foreach(string str in IMGfiles)
            {
                File.Delete(str);
            }
        }

        public static void EliminarClube(Clube _este)
        {
            OleDbConnection _connection = new OleDbConnection();
            _connection.ConnectionString = ConfigurationManager.ConnectionStrings["BDRascalconnectionString"].ToString();
            _connection.Open();

            //Inserir novo modelo
            OleDbCommand _command = new OleDbCommand();
            _command.Connection = _connection;
            _command.CommandType = CommandType.Text;
            _command.CommandText = "DELETE FROM Clube WHERE ID=" + _este.ID;
            _command.ExecuteNonQuery();

            _connection.Close();

            //apagar foto
            File.Delete("E:\\Rascal\\CLubes\\" + _este.NomeFoto);
        }

        //OUTROS NOMES
        public static void GuardarNovoOutroNome(int _ID, string Nome)
        {
            OleDbConnection _connection = new OleDbConnection();
            _connection.ConnectionString = ConfigurationManager.ConnectionStrings["BDRascalconnectionString"].ToString();
            _connection.Open();

            //Inserir novo modelo
            OleDbCommand _command = new OleDbCommand();
            _command.Connection = _connection;
            _command.CommandType = CommandType.Text;
            _command.CommandText = "INSERT INTO OutrosNomes (IdModelo, Nome, DateCreated) VALUES (" + _ID + ", '" + Nome + "', '" + DateTime.Now + "')";
            _command.ExecuteNonQuery();

            _connection.Close();
        }

        public static List<OutrosNomes> BuscarOutrosNomesDela(int _ID)
        {
            List<OutrosNomes> _lisNomes = new List<OutrosNomes>();

            CultureInfo PTCultureInfo = new CultureInfo("pt-PT");

            OleDbConnection _connection = new OleDbConnection();
            _connection.ConnectionString = ConfigurationManager.ConnectionStrings["BDRascalconnectionString"].ToString();

            try
            {
                _connection.Open();
                OleDbCommand cmd = new OleDbCommand("SELECT * FROM OutrosNomes WHERE IdModelo=" + _ID, _connection);

                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    _lisNomes.Add(new OutrosNomes
                    {
                        ID = Convert.ToInt32(reader.GetValue(0)),
                        IdModelo = Convert.ToInt32(reader.GetValue(1)),
                        Nome = reader.GetString(2),
                        DateCreated = DateTime.Parse(reader.GetValue(3).ToString(), PTCultureInfo)
                    });
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
            finally
            {
                _connection.Close();
            }

            return _lisNomes;
        }

        public static void RemoverOutroNome(int _ID)
        {
            OleDbConnection _connection = new OleDbConnection();
            _connection.ConnectionString = ConfigurationManager.ConnectionStrings["BDRascalconnectionString"].ToString();
            _connection.Open();

            //Inserir novo modelo
            OleDbCommand _command = new OleDbCommand();
            _command.Connection = _connection;
            _command.CommandType = CommandType.Text;
            _command.CommandText = "DELETE FROM OutrosNomes WHERE ID=" + _ID;
            _command.ExecuteNonQuery();

            _connection.Close();
        }

        //PERTENCE A
        public static List<PertenceA> BuscarClubesModelo(int _ID)
        {
            List<PertenceA> listClubesPertence = new List<PertenceA>();

            CultureInfo PTCultureInfo = new CultureInfo("pt-PT");

            OleDbConnection _connection = new OleDbConnection();
            _connection.ConnectionString = ConfigurationManager.ConnectionStrings["BDRascalconnectionString"].ToString();

            try
            {
                _connection.Open();
                OleDbCommand cmd = new OleDbCommand("SELECT * FROM PertenceA WHERE Identificador=" + _ID + "AND Tipo=1", _connection);

                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    listClubesPertence.Add(new PertenceA
                    {
                        ID = Convert.ToInt32(reader.GetValue(0)),
                        Identificador = Convert.ToInt32(reader.GetValue(1)),
                        IdClube = Convert.ToInt32(reader.GetValue(2)),
                        Tipo = Convert.ToInt32(reader.GetValue(3)),
                        DateCreated = DateTime.Parse(reader.GetValue(4).ToString(), PTCultureInfo)
                    });
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine(ex.Message);
                return null;
            }
            finally
            {
                _connection.Close();
            }

            return listClubesPertence;
        }

        public static void EliminarAssociacoes(int _ID)
        {
            OleDbConnection _connection = new OleDbConnection();
            _connection.ConnectionString = ConfigurationManager.ConnectionStrings["BDRascalconnectionString"].ToString();
            _connection.Open();

            //Apagar modelo
            OleDbCommand _command = new OleDbCommand();
            _command.Connection = _connection;
            _command.CommandType = CommandType.Text;
            _command.CommandText = "DELETE FROM PertenceA WHERE Identificador=" + _ID;
            _command.ExecuteNonQuery();

            _connection.Close();
        }

        public static void CriarNovaAssociacao(int ide, int IDclube, int Tipo)
        {
            OleDbConnection _connection = new OleDbConnection();
            _connection.ConnectionString = ConfigurationManager.ConnectionStrings["BDRascalconnectionString"].ToString();
            _connection.Open();

            //Inserir novo modelo
            OleDbCommand _command = new OleDbCommand();
            _command.Connection = _connection;
            _command.CommandType = CommandType.Text;
            _command.CommandText = "INSERT INTO PertenceA (Identificador, IdClube, Tipo, DateCreated) VALUES (" + ide + ", " + IDclube + ", " + Tipo + ", '" + DateTime.Now + "')";
            _command.ExecuteNonQuery();

            _connection.Close();
        }

        //OUTRAS
        public static void GuardarNovaOutra(string caminhoFoto)
        {
            string[] parts = caminhoFoto.Split('\\');            
            string[] nnome = parts[parts.Count() - 1].Split('.');
            nnome[0] = RemoveSpecialCharacters(nnome[0]);
            string NovoCaminho = "E:\\Rascal\\Outras\\" + nnome[0] + "." + nnome[1];

            if (!Directory.Exists("E:\\Rascal\\Outras"))
                Directory.CreateDirectory("E:\\Rascal\\Outras");            

            OleDbConnection _connection = new OleDbConnection();
            _connection.ConnectionString = ConfigurationManager.ConnectionStrings["BDRascalconnectionString"].ToString();
            _connection.Open();

            //Inserir novo modelo
            OleDbCommand _command = new OleDbCommand();
            _command.Connection = _connection;
            _command.CommandType = CommandType.Text;
            _command.CommandText = "INSERT INTO Outras (CaminhoFoto, DateCreated, Visualizacoes) VALUES ('" + NovoCaminho + "', '" + DateTime.Now + "', 0)";
            _command.ExecuteNonQuery();

            _connection.Close();

            File.Move(caminhoFoto, NovoCaminho);
        }

        public static List<Outras> BuscarOutras()
        {
            List<Outras> listOutras = new List<Outras>();

            CultureInfo PTCultureInfo = new CultureInfo("pt-PT");

            OleDbConnection _connection = new OleDbConnection();
            _connection.ConnectionString = ConfigurationManager.ConnectionStrings["BDRascalconnectionString"].ToString();

            try
            {
                _connection.Open();
                OleDbCommand cmd = new OleDbCommand("SELECT * FROM Outras", _connection);

                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    listOutras.Add(new Outras
                    {
                        ID = Convert.ToInt32(reader.GetValue(0)),
                        CaminhoFoto = reader.GetString(1),                        
                        DateCreated = DateTime.Parse(reader.GetValue(2).ToString(), PTCultureInfo),
                        Visualizacoes = Convert.ToInt32(reader.GetValue(3))
                    });
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine(ex.Message);
                return null;
            }
            finally
            {
                _connection.Close();
            }

            return listOutras;
        }

        //ERMOS
        public static DateTime GuardarNovoErmo(string designacao)
        {
            DateTime MesmoAgora = DateTime.Now;

            OleDbConnection _connection = new OleDbConnection();
            _connection.ConnectionString = ConfigurationManager.ConnectionStrings["BDRascalconnectionString"].ToString();
            _connection.Open();

            //Inserir novo modelo
            OleDbCommand _command = new OleDbCommand();
            _command.Connection = _connection;
            _command.CommandType = CommandType.Text;
            _command.CommandText = "INSERT INTO Ermo (Designacao, DateCreated) VALUES ('" + designacao + "', '" + MesmoAgora + "')";
            _command.ExecuteNonQuery();

            _connection.Close();

            //Criar novo diretório
            Directory.CreateDirectory("E:\\Rascal\\Ermos\\" + RemoveWhitespace(designacao));

            return MesmoAgora;
        }

        public static Ermo BuscarUltimoErmo(DateTime DatetimeRegistado)
        {
            Ermo este = new Ermo();
           
            OleDbConnection _connection = new OleDbConnection();
            _connection.ConnectionString = ConfigurationManager.ConnectionStrings["BDRascalconnectionString"].ToString();

            try
            {
                _connection.Open();
                OleDbCommand cmd = new OleDbCommand("SELECT * FROM Ermo", _connection);

                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    DateTime x = DateTime.Parse(reader.GetValue(2).ToString());

                    if (EqualsUpToSeconds(x, DatetimeRegistado))
                    {
                        este.ID = Convert.ToInt32(reader.GetValue(0));
                        este.Designacao = reader.GetString(1);
                        este.DateCreated = DateTime.Parse(reader.GetValue(2).ToString());
                    }                    
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
            finally
            {
                _connection.Close();
            }

            return este;
        }

        public static List<Ermo> BuscarErmos()
        {
            List<Ermo> listErmos = new List<Ermo>();

            CultureInfo PTCultureInfo = new CultureInfo("pt-PT");

            OleDbConnection _connection = new OleDbConnection();
            _connection.ConnectionString = ConfigurationManager.ConnectionStrings["BDRascalconnectionString"].ToString();

            try
            {
                _connection.Open();
                OleDbCommand cmd = new OleDbCommand("SELECT * FROM Ermo", _connection);

                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    listErmos.Add(new Ermo
                    {
                        ID = Convert.ToInt32(reader.GetValue(0)),
                        Designacao = reader.GetString(1),
                        DateCreated = DateTime.Parse(reader.GetValue(2).ToString(), PTCultureInfo)
                    });
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine(ex.Message);
                return null;
            }
            finally
            {
                _connection.Close();
            }

            return listErmos;
        }

        public static void EditarErmo(string novaDesignacao, Ermo _este)
        {
            OleDbConnection _connection = new OleDbConnection();
            _connection.ConnectionString = ConfigurationManager.ConnectionStrings["BDRascalconnectionString"].ToString();
            _connection.Open();

            //Inserir novo modelo
            OleDbCommand _command = new OleDbCommand();
            _command.Connection = _connection;
            _command.CommandType = CommandType.Text;
            _command.CommandText = "UPDATE Ermo SET Designacao='" + novaDesignacao + "' WHERE ID=" + _este.ID;
            _command.ExecuteNonQuery();

            _connection.Close();

            //Criar novo Directorio
            Directory.CreateDirectory("E:\\Rascal\\Ermos\\" + RemoveWhitespace(novaDesignacao));
            string NovoCaminho = "E:\\Rascal\\Ermos\\" + RemoveWhitespace(novaDesignacao) + "\\";

            //Atualizar fotos
            List<Foto> _pics = BuscarFotos();
            string[] CaminhosAntigos = Directory.GetFiles("E:\\Rascal\\Ermos\\" + RemoveWhitespace(_este.Designacao));

            foreach (Foto ft in _pics)
            {
                foreach (string Acaminho in CaminhosAntigos)
                {
                    if (ft.CaminhoFoto == Acaminho)
                    {
                        string[] Nomes = Acaminho.Split('\\');

                        //Editar
                        EditarFoto(NovoCaminho + Nomes[Nomes.Count() - 1], ft.ID);

                        //Move-la
                        File.Move(Acaminho, NovoCaminho + Nomes[Nomes.Count() - 1]);
                    }
                }
            }

            //Apagar Diretorio antigo
            Directory.Delete("E:\\Rascal\\Ermos\\" + RemoveWhitespace(_este.Designacao));
        }

        public static void ApagarTodosErmos()
        {
            //Buscar todos os Ermos
            List<Ermo> TodosErmos = BuscarErmos();

            //Apagar todos os diretórios e todas as suas fotos
            foreach(Ermo rm in TodosErmos)
            {
                Directory.Delete("E:\\Rascal\\Ermos\\" + RemoveWhitespace(rm.Designacao), true);
            }

            //Apagar dados da tabela
            OleDbConnection _connection = new OleDbConnection();
            _connection.ConnectionString = ConfigurationManager.ConnectionStrings["BDRascalconnectionString"].ToString();
            _connection.Open();

            //Inserir novo modelo
            OleDbCommand _command = new OleDbCommand();
            _command.Connection = _connection;
            _command.CommandType = CommandType.Text;
            _command.CommandText = "DELETE FROM Ermo";
            _command.ExecuteNonQuery();

            _connection.Close();
        }

        public static void EliminarErmo(Ermo _este)
        {
            OleDbConnection _connection = new OleDbConnection();
            _connection.ConnectionString = ConfigurationManager.ConnectionStrings["BDRascalconnectionString"].ToString();
            _connection.Open();

            //Inserir novo modelo
            OleDbCommand _command = new OleDbCommand();
            _command.Connection = _connection;
            _command.CommandType = CommandType.Text;
            _command.CommandText = "DELETE FROM Ermo WHERE ID=" + _este.ID;
            _command.ExecuteNonQuery();

            _connection.Close();

            //Apagar fotos e directorio
            Directory.Delete("E:\\Rascal\\Ermos\\" + _este.Designacao, true);
        }

        //GALERIAS
        public static List<Galeria> BuscarGalerias()
        {
            List<Galeria> listaGalerias = new List<Galeria>();

            CultureInfo PTCultureInfo = new CultureInfo("pt-PT");

            OleDbConnection _connection = new OleDbConnection();
            _connection.ConnectionString = ConfigurationManager.ConnectionStrings["BDRascalconnectionString"].ToString();

            try
            {
                _connection.Open();
                OleDbCommand cmd = new OleDbCommand("SELECT * FROM Galeria", _connection);

                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    listaGalerias.Add(new Galeria
                    {
                        ID = Convert.ToInt32(reader.GetValue(0)),
                        Identificador = Convert.ToInt32(reader.GetValue(1)),
                        Tipo = Convert.ToInt32(reader.GetValue(2)),
                        Designacao = reader.GetString(3),
                        Visualizacoes = Convert.ToInt32(reader.GetValue(4)),
                        DateCreated = DateTime.Parse(reader.GetValue(5).ToString(), PTCultureInfo)
                    });
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine(ex.Message);
                return null;
            }
            finally
            {
                _connection.Close();
            }

            return listaGalerias;
        }

        public static List<Galeria> BuscarGaleriasDELA(int _ID)
        {
            List<Galeria> listaGalerias = new List<Galeria>();

            CultureInfo PTCultureInfo = new CultureInfo("pt-PT");

            OleDbConnection _connection = new OleDbConnection();
            _connection.ConnectionString = ConfigurationManager.ConnectionStrings["BDRascalconnectionString"].ToString();

            try
            {
                _connection.Open();
                OleDbCommand cmd = new OleDbCommand("SELECT * FROM Galeria WHERE ID=" + _ID, _connection);

                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    listaGalerias.Add(new Galeria
                    {
                        ID = Convert.ToInt32(reader.GetValue(0)),
                        Identificador = Convert.ToInt32(reader.GetValue(1)),
                        Tipo = Convert.ToInt32(reader.GetValue(2)),
                        Designacao = reader.GetString(3),
                        Visualizacoes = Convert.ToInt32(reader.GetValue(4)),
                        DateCreated = DateTime.Parse(reader.GetValue(5).ToString(), PTCultureInfo)
                    });
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine(ex.Message);
                return null;
            }
            finally
            {
                _connection.Close();
            }

            return listaGalerias;
        }

        public static void EliminarGaleria(string caminho, int _ID)
        {
            OleDbConnection _connection = new OleDbConnection();
            _connection.ConnectionString = ConfigurationManager.ConnectionStrings["BDRascalconnectionString"].ToString();
            _connection.Open();

            //Inserir novo modelo
            OleDbCommand _command = new OleDbCommand();
            _command.Connection = _connection;
            _command.CommandType = CommandType.Text;
            _command.CommandText = "DELETE FROM Galeria WHERE ID=" + _ID;
            _command.ExecuteNonQuery();

            _connection.Close();

            //Apagar tudo
            Directory.Delete(caminho, true);
        }

        //FOTOS
        public static void GuardarNovaErmoFoto(Ermo EsteErmo, string caminhoFoto, int index)
        {
            //Verificar diretório
            if (!Directory.Exists("E:\\Rascal\\Ermos\\" + RemoveWhitespace(EsteErmo.Designacao)))
                Directory.CreateDirectory("E:\\Rascal\\Ermos\\" + RemoveWhitespace(EsteErmo.Designacao));

            //Novo caminho
            string[] parts = caminhoFoto.Split('\\');
            string[] parts2 = parts[parts.Count() - 1].Split('.');
            string NovoCaminho = "E:\\Rascal\\Ermos\\" + RemoveWhitespace(EsteErmo.Designacao) + "\\" + RemoveWhitespace(EsteErmo.Designacao) + index + "." + parts2[1];

            OleDbConnection _connection = new OleDbConnection();
            _connection.ConnectionString = ConfigurationManager.ConnectionStrings["BDRascalconnectionString"].ToString();
            _connection.Open();

            //Inserir novo modelo
            OleDbCommand _command = new OleDbCommand();
            _command.Connection = _connection;
            _command.CommandType = CommandType.Text;
            _command.CommandText = "INSERT INTO Foto (IdGaleria, CaminhoFoto, Visualizacoes, DateCreated) VALUES (" + EsteErmo.ID + ", '" + NovoCaminho + "', " + 0  +", '" + DateTime.Now + "')";
            _command.ExecuteNonQuery();

            _connection.Close();

            //Deslocar foto
            File.Move(caminhoFoto, NovoCaminho);
        }

        public static List<Foto> BuscarFotos()
        {
            List<Foto> listFotos = new List<Foto>();

            CultureInfo PTCultureInfo = new CultureInfo("pt-PT");

            OleDbConnection _connection = new OleDbConnection();
            _connection.ConnectionString = ConfigurationManager.ConnectionStrings["BDRascalconnectionString"].ToString();

            try
            {
                _connection.Open();
                OleDbCommand cmd = new OleDbCommand("SELECT * FROM Foto", _connection);

                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    listFotos.Add(new Foto
                    {
                        ID = Convert.ToInt32(reader.GetValue(0)),
                        IdGaleria = Convert.ToInt32(reader.GetValue(1)),
                        CaminhoFoto = reader.GetString(2),
                        Visualizacoes = Convert.ToInt32(reader.GetValue(3)),
                        DateCreated = DateTime.Parse(reader.GetValue(4).ToString(), PTCultureInfo)
                    });
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine(ex.Message);
                return null;
            }
            finally
            {
                _connection.Close();
            }

            return listFotos;
        }

        public static List<Foto> BuscarFotosGaleria(int GaleriaID)
        {
            List<Foto> listFotos = new List<Foto>();

            CultureInfo PTCultureInfo = new CultureInfo("pt-PT");

            OleDbConnection _connection = new OleDbConnection();
            _connection.ConnectionString = ConfigurationManager.ConnectionStrings["BDRascalconnectionString"].ToString();

            try
            {
                _connection.Open();
                OleDbCommand cmd = new OleDbCommand("SELECT * FROM Foto WHERE IdGaleria=" + GaleriaID, _connection);

                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    listFotos.Add(new Foto
                    {
                        ID = Convert.ToInt32(reader.GetValue(0)),
                        IdGaleria = Convert.ToInt32(reader.GetValue(1)),
                        CaminhoFoto = reader.GetString(2),
                        Visualizacoes = Convert.ToInt32(reader.GetValue(3)),
                        DateCreated = DateTime.Parse(reader.GetValue(4).ToString(), PTCultureInfo)
                    });
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine(ex.Message);
                return null;
            }
            finally
            {
                _connection.Close();
            }

            return listFotos;
        }

        public static void EditarFoto(string Newpath, int _ID)
        {
            OleDbConnection _connection = new OleDbConnection();
            _connection.ConnectionString = ConfigurationManager.ConnectionStrings["BDRascalconnectionString"].ToString();
            _connection.Open();

            //Editar foto
            OleDbCommand _command = new OleDbCommand();
            _command.Connection = _connection;
            _command.CommandType = CommandType.Text;
            _command.CommandText = "UPDATE Foto SET CaminhoFoto='" + Newpath + "' WHERE ID=" + _ID;
            _command.ExecuteNonQuery();

            _connection.Close();
        }

        public static void EliminarFoto(Foto _esta)
        {
            OleDbConnection _connection = new OleDbConnection();
            _connection.ConnectionString = ConfigurationManager.ConnectionStrings["BDRascalconnectionString"].ToString();
            _connection.Open();

            //Inserir novo modelo
            OleDbCommand _command = new OleDbCommand();
            _command.Connection = _connection;
            _command.CommandType = CommandType.Text;
            _command.CommandText = "DELETE FROM Foto WHERE ID=" + _esta.ID;
            _command.ExecuteNonQuery();

            _connection.Close();

            //Apagar foto
            File.Delete(_esta.CaminhoFoto);
        }

    }
}
