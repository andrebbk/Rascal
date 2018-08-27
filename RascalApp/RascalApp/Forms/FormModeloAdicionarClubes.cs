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
        public bool RefreshCLubes;

        public FormModeloAdicionarClubes(FormInicio _formI, int _ID)
        {
            InitializeComponent();

            _FormInicio = _formI;
            ModeloID = _ID;
            _listaAssociacoes = new List<PertenceA>();
            _listaClubes = new List<Clube>();
            RefreshCLubes = false;

            CarregarLista();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            RefreshCLubes = true;

            //Verificar alterações
            foreach (ListViewItem item in listViewClubes.Items)
            {
                if (listViewClubes.Items[item.Index].Selected)
                {
                    RefreshCLubes = false;

                    foreach(PertenceA prtnc in _listaAssociacoes)
                    {
                        if(prtnc.IdClube == Convert.ToInt32(item.Tag))
                        {
                            RefreshCLubes = true;
                        }
                    }
                }
            }

            bool TemSelecionados = false;

            foreach (ListViewItem item in listViewClubes.Items)
            {
                if (listViewClubes.Items[item.Index].Selected)
                {
                    TemSelecionados = true;
                    break;
                }
            }

            //Senao houve alterações, sair!
            if (!RefreshCLubes && !TemSelecionados)
                return;

            try
            {
                //Apagar todas as associacoes com o Id do Modelo
                Funcionalidades.EliminarAssociacoes(ModeloID);
            }
            catch
            {
                _FormInicio.EscreverNaConsola("Erro ao apagar associações!");
            }

            try
            {
                foreach (ListViewItem item in listViewClubes.Items)
                {
                    if (listViewClubes.Items[item.Index].Selected)
                    {
                        //Se o clube estiver selecionado, criar associacao
                        Funcionalidades.CriarNovaAssociacao(ModeloID, Convert.ToInt32(item.Tag), 1);
                    }
                }
            }
            catch
            {
                _FormInicio.EscreverNaConsola("Erro ao guardar associações!");
            }

            RefreshCLubes = true;

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
                ListaImagens.ImageSize = new Size(200, 70);
                ListaImagens.ColorDepth = ColorDepth.Depth32Bit;

                foreach (Clube clb in _listaClubes)
                {
                    byte[] buff = System.IO.File.ReadAllBytes("E:\\Rascal\\Clubes\\" + clb.NomeFoto);

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

            listViewClubes.HideSelection = false;

            //Selecionar os items
            foreach (PertenceA prtnc in _listaAssociacoes)
            {
                foreach(ListViewItem item in listViewClubes.Items)
                {
                    if(prtnc.IdClube.ToString() == item.Tag.ToString())
                    {
                        listViewClubes.Items[item.Index].Selected = true;
                    }
                }
            }
        }
    }
}
