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
        public FormVerImagem(int Ide, int tipo)
        {
            InitializeComponent();

            //Tipo 1 -> Galerias
            //Tipo 2 -> Outras
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
    }
}
