using System;
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
            _command.CommandText = "INSERT INTO Modelo (Nome, CaminhoFoto, DateCreated) VALUES ('" + Nome + "', '" + caminhoFoto + "', '" + DateTime.Now +"')";
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
            _command.CommandText = "INSERT INTO Clube (Nome, NomeFoto, DateCreated) VALUES ('" + Nome + "', '" + NomeFoto + "', '" + DateTime.Now + "')";
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
                NNomeFoto = NNome + "." + parts2[parts2.Count() - 1];
            else
                NNomeFoto = NNome + "." + parts[parts.Count() - 1];

            OleDbConnection _connection = new OleDbConnection();
            _connection.ConnectionString = ConfigurationManager.ConnectionStrings["BDRascalconnectionString"].ToString();
            _connection.Open();

            //Inserir novo modelo
            OleDbCommand _command = new OleDbCommand();
            _command.Connection = _connection;
            _command.CommandType = CommandType.Text;
            _command.CommandText = "UPDATE Clube SET Nome='" + NNome + "', NomeFoto='" + NNomeFoto + "' WHERE ID=" + _este.ID;
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
                        ft.CaminhoFoto = NovoCaminho + Nomes[Nomes.Count() - 1];
                        EditarFoto(ft);

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

        public static void EditarFoto(Foto _esta)
        {
            OleDbConnection _connection = new OleDbConnection();
            _connection.ConnectionString = ConfigurationManager.ConnectionStrings["BDRascalconnectionString"].ToString();
            _connection.Open();

            //Editar foto
            OleDbCommand _command = new OleDbCommand();
            _command.Connection = _connection;
            _command.CommandType = CommandType.Text;
            _command.CommandText = "UPDATE Foto SET CaminhoFoto='" + _esta.CaminhoFoto + "' WHERE ID=" + _esta.ID;
            _command.ExecuteNonQuery();

            _connection.Close();
        }

        
    }
}
