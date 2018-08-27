using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RascalApp.Forms;
using System.IO;
using RascalApp.Properties;

namespace RascalApp.UserControls
{
    public partial class UserControlNovoModelo : UserControl
    {
        private string Fotografia = "nada";
        FormInicio _FormInicio = null;
            
        public UserControlNovoModelo(FormInicio _formIni)
        {
            InitializeComponent();

            _FormInicio = _formIni;
            Fotografia = "nada";
        }

        private void buttonRegistar_Click(object sender, EventArgs e)
        {
            //Nome
            if(String.IsNullOrEmpty(textBoxNovoNome.Text) || textBoxNovoNome.Text == " ")
            {
                _FormInicio.EscreverNaConsola("Nome em falta!");
                return;
            }

            //Fotografia
            if (Fotografia == "nada")
            {
                _FormInicio.EscreverNaConsola("Foto em falta!");
                return;
            }

            try
            {
                string NomeLimpo = Funcionalidades.RemoveWhitespace(Funcionalidades.RemoveSpecialCharacters(textBoxNovoNome.Text));
                //Criar diretório para o modelo 
                if (!Directory.Exists("E:\\Rascal\\Modelos\\" + NomeLimpo))
                    Directory.CreateDirectory("E:\\Rascal\\Modelos\\" + NomeLimpo);

                //Guardar Foto
                string[] parts = Fotografia.Split('.');
                string NovaFotografia = "E:\\Rascal\\Modelos\\" + NomeLimpo + "\\FotoDela." + parts[parts.Count() - 1];
                File.Move(Fotografia, NovaFotografia);

                //Registar novo modelo
                Funcionalidades.GuardarNovoModelo(textBoxNovoNome.Text, NovaFotografia);
            }
            catch(Exception ex)
            {
                _FormInicio.EscreverNaConsola("Erro ao registar o modelo!");
                Console.WriteLine(ex.ToString());
                return;
            }            

            _FormInicio.EscreverNaConsola(textBoxNovoNome.Text + " registada!");
        
            LimparFormNovoModelo();
        }

        private void pictureBoxNovaFotoModelo_Click(object sender, EventArgs e)
        {
            //Mudar foto

            OpenFileDialog open = new OpenFileDialog();
            open.Multiselect = false;
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";

            if (open.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(open.FileName, FileMode.Open, FileAccess.Read))
                {
                    pictureBoxNovaFotoModelo.BackgroundImage = Image.FromStream(stream);
                }

                Fotografia = open.FileName;
            }
        }

        private void LimparFormNovoModelo()
        {
            textBoxNovoNome.Clear();
            pictureBoxNovaFotoModelo.BackgroundImage = Resources.portret;
            Fotografia = "nada";
        }
    }
}
