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
        private FormInicio _FormInicio;
        public string NomeEditado;
        public string FotoEditada;
        private List<Galeria> listaGalerias;

        public FormEditarModelo(Modelo _VenhaEle, bool PermitirApagar, FormInicio _fInit)
        {
            InitializeComponent();

            _este = _VenhaEle;
            _FormInicio = _fInit;
            listaGalerias = new List<Galeria>();

            if (!PermitirApagar)
            {
                buttonApagar.Hide();
                buttonEditar.Location = buttonApagar.Location;
            }

            CarregarForm();            
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
            CarregarGalerias();
        }

        private void CarregarGalerias()
        {
            listBoxGalerias.Items.Clear();
            listaGalerias.Clear();

            try
            {
                //Carregar Galerias
                listaGalerias = Funcionalidades.BuscarGaleriasDELA(_este.ID);

                foreach(Galeria glr in listaGalerias)
                {
                    listBoxGalerias.Items.Add(glr.Designacao);
                }
            }
            catch
            {
                _FormInicio.EscreverNaConsola("Erro ao carregar galerias!");
            }
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

        private void buttonApagar_Click(object sender, EventArgs e)
        {

        }

        private void buttonApagarGal_Click(object sender, EventArgs e)
        {
            //Apagar nome galeria
        }

        private void buttonOKNome_Click(object sender, EventArgs e)
        {
            //Editar nome galeria
        }

        private void listBoxGalerias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxGalerias.SelectedIndex == -1)
            {
                textBoxNNomeGal.Clear();
            }
            else
            {
                textBoxNNomeGal.Text = listaGalerias[listBoxGalerias.SelectedIndex].Designacao;
            }
                
        }
    }
}
