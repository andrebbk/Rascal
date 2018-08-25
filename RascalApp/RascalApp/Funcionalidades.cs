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
            string NovoCaminho = "E:\\Rascal\\Outras\\" + parts[parts.Count() - 1];

            if (!Directory.Exists("E:\\Rascal\\Outras"))
                Directory.CreateDirectory("E:\\Rascal\\Outras");

            File.Move(caminhoFoto, NovoCaminho);

            OleDbConnection _connection = new OleDbConnection();
            _connection.ConnectionString = ConfigurationManager.ConnectionStrings["BDRascalconnectionString"].ToString();
            _connection.Open();

            //Inserir novo modelo
            OleDbCommand _command = new OleDbCommand();
            _command.Connection = _connection;
            _command.CommandType = CommandType.Text;
            _command.CommandText = "INSERT INTO Outras (CaminhoFoto, DateCreated) VALUES ('" + NovoCaminho + "', '" + DateTime.Now + "')";
            _command.ExecuteNonQuery();

            _connection.Close();
        }
    }
}
