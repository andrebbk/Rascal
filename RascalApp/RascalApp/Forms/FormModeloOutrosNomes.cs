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
    public partial class FormModeloOutrosNomes : Form
    {
        private FormInicio _FormInicio;
        private int IdModelo;
        private List<OutrosNomes> listaOutrosNomes;
        public bool FoiAlterado;

        public FormModeloOutrosNomes(FormInicio _formI, int _ID)
        {
            InitializeComponent();

            _FormInicio = _formI;
            IdModelo = _ID;
            listaOutrosNomes = new List<OutrosNomes>();
            FoiAlterado = false;

            CarregarListBoxNomes();
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            FoiAlterado = true;
            buttonSair.Enabled = false;
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(textBoxNovoNome.Text) || textBoxNovoNome.Text == " ")
            {
                _FormInicio.EscreverNaConsola("Nome em falta!");
                return;
            }

            try
            {
                Funcionalidades.GuardarNovoOutroNome(IdModelo, textBoxNovoNome.Text);
                FoiAlterado = true;
                buttonSair.Enabled = false;

                CarregarListBoxNomes();
                textBoxNovoNome.Clear();
            }
            catch
            {
                _FormInicio.EscreverNaConsola("Erro ao guardar outro nome!");
            }                     
        }

        private void CarregarListBoxNomes()
        {
            listBoxOutrosNomes.Items.Clear();
            listaOutrosNomes.Clear();

            listaOutrosNomes = Funcionalidades.BuscarOutrosNomesDela(IdModelo);

            foreach(OutrosNomes trsnms in listaOutrosNomes)
            {
                listBoxOutrosNomes.Items.Add(trsnms.Nome);                
            }
        }

        private void listBoxOutrosNomes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxOutrosNomes.SelectedIndex > -1)
                textBoxNovoNome.Text = listBoxOutrosNomes.SelectedItem.ToString();
        }

        private void buttonRemover_Click(object sender, EventArgs e)
        {
            if (listBoxOutrosNomes.SelectedIndex == -1)
            {
                _FormInicio.EscreverNaConsola("Nenhum nome selecionado!");
                return;
            }

            int _index = listBoxOutrosNomes.SelectedIndex;

            try
            {
                Funcionalidades.RemoverOutroNome(listaOutrosNomes[_index].ID);
            }
            catch
            {
                _FormInicio.EscreverNaConsola("Erro ao eliminar outro nome!");
            }

            _FormInicio.EscreverNaConsola("Nome eliminado!");
            FoiAlterado = true;
            buttonSair.Enabled = false;
            listBoxOutrosNomes.SelectedIndex = -1;
            textBoxNovoNome.Clear();
            CarregarListBoxNomes();
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
        }
    }
}
