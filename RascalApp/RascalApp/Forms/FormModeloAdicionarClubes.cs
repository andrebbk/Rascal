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
    public partial class FormModeloAdicionarClubes : Form
    {
        private FormInicio _FormInicio;
        private int ModeloID;
        private List<PertenceA> _listaAssociacoes;
        private List<Clube> _listaClubes;

        public FormModeloAdicionarClubes(FormInicio _formI, int _ID)
        {
            InitializeComponent();

            _FormInicio = _formI;
            ModeloID = _ID;
            _listaAssociacoes = new List<PertenceA>();
            _listaClubes = new List<Clube>();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {

        }

        private void CarregarLista()
        {
            listViewClubes.Items.Clear();
            _listaAssociacoes.Clear();
            _listaClubes.Clear();
           
            try
            {
                //Listas de clubes
                _listaAssociacoes = Funcionalidades.BuscarClubesModelo(ModeloID);
                _listaClubes = Funcionalidades.BuscarClubes();

                ImageList ListaImagens = new ImageList();
                ListaImagens.ImageSize = new Size(256, 190);
                ListaImagens.ColorDepth = ColorDepth.Depth32Bit;

                foreach (Clube clb in _listaClubes)
                {
                    string[] rmImagens = Directory.GetFiles("E:\\Rascal\\Clubes\\" + Funcionalidades.RemoveWhitespace(Funcionalidades.RemoveSpecialCharacters(clb.Nome)));
                    byte[] buff = System.IO.File.ReadAllBytes(rmImagens[0]);

                    using (System.IO.MemoryStream ms = new System.IO.MemoryStream(buff))
                    {
                        ListaImagens.Images.Add(Funcionalidades.RemoveWhitespace(clb.Nome), Image.FromStream(ms));
                    }
                }

                listViewClubes.View = View.LargeIcon;
                listViewClubes.LargeImageList = ListaImagens;

                foreach (Clube clb in _listaClubes)
                {
                    ListViewItem lst = new ListViewItem();
                    lst.Text = clb.Nome;
                    lst.ImageIndex = 0;
                    lst.Tag = clb.ID;
                    lst.ImageKey = Funcionalidades.RemoveWhitespace(clb.Nome);
                    listViewClubes.Items.Add(lst);
                }

                labelNClubesSelected.Text = _listaAssociacoes.Count().ToString();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine(ex.Message);
                _FormInicio.EscreverNaConsola("Erro ao carregar os Clubes!");
            }
        }
    }
}
