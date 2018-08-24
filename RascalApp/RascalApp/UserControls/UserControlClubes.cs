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
    public partial class UserControlClubes : UserControl
    {
        FormInicio _FormInicio;
        private string Foto = "nada";

        public UserControlClubes(FormInicio _formIni)
        {
            InitializeComponent();

            _FormInicio = _formIni;
        }

        private void UserControlClubes_Load(object sender, EventArgs e)
        {

        }

        private void buttonRegistarClube_Click(object sender, EventArgs e)
        {
            //Nome
            if (String.IsNullOrEmpty(textBoxNovoNome.Text) || textBoxNovoNome.Text == " ")
            {
                _FormInicio.EscreverNaConsola("Nome em falta!");
                return;
            }

            //Fotografia
            if (Foto == "nada")
            {
                _FormInicio.EscreverNaConsola("Foto em falta!");
                return;
            }

            try
            {
                //Verificar diretório  dos clubes 
                if (!Directory.Exists("E:\\Rascal\\Clubes"))
                    Directory.CreateDirectory("E:\\Rascal\\Clubes");

                //Guardar Foto
                string[] parts = Foto.Split('.');
                string NovaFoto = "E:\\Rascal\\Clubes\\" + textBoxNovoNome.Text + "." + parts[parts.Count() - 1];
                File.Move(Foto, NovaFoto);

                //Registar novo clube
                Funcionalidades.GuardarNovoClube(textBoxNovoNome.Text, textBoxNovoNome.Text + "." + parts[parts.Count() - 1]);
            }
            catch (Exception ex)
            {
                _FormInicio.EscreverNaConsola("Erro ao registar o clube!");
                Console.WriteLine(ex.ToString());
                return;
            }

            _FormInicio.EscreverNaConsola(textBoxNovoNome.Text + " registado!");

            LimparFormNovoClube();
        }

        private void LimparFormNovoClube()
        {
            pictureBoxNovaFota.BackgroundImage = Resources.if_HP_Pictures_Folder_Dock_512_17259;
            Foto = "nada";
            textBoxNovoNome.Clear();
        }

        private void pictureBoxNovaFota_Click(object sender, EventArgs e)
        {
            //Mudar foto

            OpenFileDialog open = new OpenFileDialog();
            open.Multiselect = false;
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";

            if (open.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(open.FileName, FileMode.Open, FileAccess.Read))
                {
                    pictureBoxNovaFota.BackgroundImage = Image.FromStream(stream);
                }

                Foto = open.FileName;
            }
        }
    }
}
