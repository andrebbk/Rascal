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
    public partial class FormEditarClube : Form
    {
        Clube CLB;
        public string NomeEditado;
        public string FotoEditada;

        public FormEditarClube(Clube _clb)
        {
            InitializeComponent();

            CLB = _clb;
            NomeEditado = "nop";
            FotoEditada = "nop";

            LoadFormEditar();
        }

        private void LoadFormEditar()
        {
            //Nome
            textBoxNovoNome.Text = CLB.Nome;

            //Imagem
            byte[] buff = System.IO.File.ReadAllBytes("E:\\Rascal\\Clubes\\" + CLB.NomeFoto);
            using (System.IO.MemoryStream ms = new System.IO.MemoryStream(buff))
            {
                pictureBoxClubePic.BackgroundImage = Image.FromStream(ms);
            }
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            NomeEditado = textBoxNovoNome.Text;
        }

        private void pictureBoxClubePic_Click(object sender, EventArgs e)
        {
            //Mudar foto

            OpenFileDialog open = new OpenFileDialog();
            open.Multiselect = false;
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";

            if (open.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(open.FileName, FileMode.Open, FileAccess.Read))
                {
                    pictureBoxClubePic.BackgroundImage = Image.FromStream(stream);
                }

                FotoEditada = open.FileName;
            }
        }
    }
}
