using RascalApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RascalApp.Forms
{
    public partial class FormVerImagem : Form
    {
        private int tipo;
        private int PicID;
        //Tipo 1 -> Galerias
        //Tipo 2 -> Outras
        public FormVerImagem(int Ide, int _tipo)
        {
            InitializeComponent();
            tipo = _tipo;
            PicID = Ide;
        }

        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxRightArrow_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxLeftArrow_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxApagarPic_Click(object sender, EventArgs e)
        {
            //Apagar
            FormPopUp PopupConfirmation = new FormPopUp("Tem a certeza que pertende eliminar a imagem?");
            DialogResult resultadoPopup = PopupConfirmation.ShowDialog();

            if (resultadoPopup == DialogResult.Yes)
            {                
                //Apagar foto
            }
        }

        private void FormVerImagem_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {

            }

            if (e.KeyCode == Keys.Right)
            {

            }
        }

        private void FormVerImagem_Load(object sender, EventArgs e)
        {
            if (tipo != 1 && tipo != 2)
                this.Close();
        }
    }
}
