using RascalApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RascalApp.Forms
{
    public partial class FormEditarModelo : Form
    {
        private Modelo _este;
        public string NomeEditado;
        public string FotoEditada;

        public FormEditarModelo(Modelo _VenhaEle)
        {
            InitializeComponent();

            _este = _VenhaEle;

            CarregarForm();
        }

        private void buttonOKNome_Click(object sender, EventArgs e)
        {

        }

        private void CarregarForm()
        {
            //Valores das variaveis
            NomeEditado = _este.Nome;
            FotoEditada = _este.CaminhoFoto;

            //TextBox NOME
            textBoxNovoNome.Text = _este.Nome;

            //FOTO
            byte[] buff = System.IO.File.ReadAllBytes(_este.CaminhoFoto);
            using (System.IO.MemoryStream ms = new System.IO.MemoryStream(buff))
            {
                pictureBoxModeloPic.BackgroundImage = Image.FromStream(ms);
            }

            //ListBox Galerias
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            NomeEditado = textBoxNovoNome.Text;
        }

        private void pictureBoxModeloPic_Click(object sender, EventArgs e)
        {
            //Mudar foto

            OpenFileDialog open = new OpenFileDialog();
            open.Multiselect = false;
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";

            if (open.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(open.FileName, FileMode.Open, FileAccess.Read))
                {
                    pictureBoxModeloPic.BackgroundImage = Image.FromStream(stream);
                }

                FotoEditada = open.FileName;
            }
        }
    }
}
