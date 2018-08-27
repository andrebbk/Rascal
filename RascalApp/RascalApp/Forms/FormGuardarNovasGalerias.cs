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
    public partial class FormGuardarNovasGalerias : Form
    { 
        private FormInicio _FormInicio;
        private List<ngModel> ListaDados;
        private Modelo EsteModelo;
        private string LastN;
        private int contador = 0;

        public FormGuardarNovasGalerias(FormInicio _fomrInit, List<ngModel> _dados, Modelo _este)
        {
            InitializeComponent();

            _FormInicio = _fomrInit;
            ListaDados = _dados;
            EsteModelo = _este;
            LastN = "/" + ListaDados.Count;

            CarregarForm(contador);
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            
        }

        private void CarregarForm(int n)
        {
            //Foto
            using (FileStream stream = new FileStream(ListaDados[n].caminhoFotos[0], FileMode.Open, FileAccess.Read))
            {
                pictureBoxImagem1.BackgroundImage = Image.FromStream(stream);
            }

            //Nome
            labelNomeA.Text = ListaDados[n].NomeGal;

            //Contador
            labelCOntador.Text = (n+1) + LastN;
        }

        private void buttonGuardar_Click_1(object sender, EventArgs e)
        {
            if(textBoxGalNovoNome.Text == " " || String.IsNullOrEmpty(textBoxGalNovoNome.Text))
            {
                _FormInicio.EscreverNaConsola("Nome em falta;");
                return;
            }

            //Guardar Galeria

            //Mover para a proxima
            contador++; 

            if(contador > (ListaDados.Count - 1))
            {
                this.Close();
                DialogResult = DialogResult.OK;
            }

            CarregarForm(contador);
        }
    }
}
