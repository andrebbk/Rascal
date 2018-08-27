using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RascalApp.Models;
using RascalApp.Forms;

namespace RascalApp.UserControls
{
    public partial class UserControlVerModelo : UserControl
    {
        private FormInicio _FormInicio;
        private Modelo EsteModelo;
        List<PertenceA> _listaAssociacoes;
        List<Clube> _listaClubes;

        public UserControlVerModelo(FormInicio _formIni, Modelo _este)
        {
            InitializeComponent();

            _FormInicio = _formIni;
            EsteModelo = _este;
            _listaAssociacoes = new List<PertenceA>();
            _listaClubes = new List<Clube>();

            CarregarDados();

            //Aumentar visualizacoes deste modelo
            Funcionalidades.AumentarModeloVisu(EsteModelo.ID, EsteModelo.Visualizacoes + 1);
        }

        private void UserControlVerModelo_Load(object sender, EventArgs e)
        {

        }

        private void CarregarDados()
        {
            labelModeloNome.Text = EsteModelo.Nome;
            labelModeloVisualizacoes.Text = EsteModelo.Visualizacoes + " visualizações";

            //FOTO
            byte[] buff = System.IO.File.ReadAllBytes(EsteModelo.CaminhoFoto);
            using (System.IO.MemoryStream ms = new System.IO.MemoryStream(buff))
            {
                pictureBoxModeloPic.BackgroundImage = Image.FromStream(ms);
            }

            //Clubes
            CarregarClubes();

            //Outros nomes
            CarregarOutrosNomes();
        }

        private void CarregarClubes()
        {
            //Limpar
            LimparPicBoxsClubes();
            _listaAssociacoes.Clear();
            _listaClubes.Clear();

            try
            {
                //Listas de clubes
                _listaAssociacoes = Funcionalidades.BuscarClubesModelo(EsteModelo.ID);
                _listaClubes = Funcionalidades.BuscarClubes();

                int contador = 1;
                Dictionary<int, PictureBox> listPicBOxs = DictioPics();

                foreach (PertenceA prtnc in _listaAssociacoes)
                {
                    foreach(Clube clb in _listaClubes)
                    {
                       if(prtnc.IdClube == clb.ID)
                       {
                            byte[] buff = System.IO.File.ReadAllBytes("E:\\Rascal\\Clubes\\" + clb.NomeFoto);
                            using (System.IO.MemoryStream ms = new System.IO.MemoryStream(buff))
                            {
                                listPicBOxs[contador].BackgroundImage = Image.FromStream(ms);
                                contador++;
                            }

                            if (contador > 6)
                                return;
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine(ex.Message);
                _FormInicio.EscreverNaConsola("Erro ao carregar os Clubes!");
            }

            GC.Collect();
        }       

        private void CarregarOutrosNomes()
        {
            List<OutrosNomes> ONomes = Funcionalidades.BuscarOutrosNomesDela(EsteModelo.ID);
            string aux = "";

            foreach (OutrosNomes nome in ONomes)
            {
                if (aux != "")
                    aux = aux + " | " + nome.Nome;
                else
                    aux = nome.Nome;
            }

            labelModeloOutrosNomes.Text = aux;
        }

        private Dictionary<int, PictureBox> DictioPics()
        {
            Dictionary<int, PictureBox> _d = new Dictionary<int, PictureBox>();
            _d.Add(1, pictureBoxModeloClube1);
            _d.Add(2, pictureBoxModeloClube2);
            _d.Add(3, pictureBoxModeloClube3);
            _d.Add(4, pictureBoxModeloClube4);
            _d.Add(5, pictureBoxModeloClube5);
            _d.Add(6, pictureBoxModeloClube6);

            return _d;
        }

        private void buttonModeloCLubes_Click(object sender, EventArgs e)
        {
            FormModeloAdicionarClubes addClubes = new FormModeloAdicionarClubes(_FormInicio, EsteModelo.ID);
            DialogResult resultado = addClubes.ShowDialog();

            if(resultado == DialogResult.OK)
            {
                if(addClubes.RefreshCLubes)
                {
                    //Atualizar os clubes
                    CarregarClubes();
                }
            }
        }

        private void LimparPicBoxsClubes()
        {
            pictureBoxModeloClube1.BackgroundImage = null;
            pictureBoxModeloClube2.BackgroundImage = null;
            pictureBoxModeloClube3.BackgroundImage = null;
            pictureBoxModeloClube4.BackgroundImage = null;
            pictureBoxModeloClube5.BackgroundImage = null;
            pictureBoxModeloClube6.BackgroundImage = null;
        }

        private void buttonModeloOutrosNomes_Click(object sender, EventArgs e)
        {
            FormModeloOutrosNomes _OutrsN = new FormModeloOutrosNomes(_FormInicio, EsteModelo.ID);
            DialogResult resultado = _OutrsN.ShowDialog();

            if(resultado == DialogResult.OK)
            {
                //Atualizar Outros Nomes
                if (_OutrsN.FoiAlterado)
                    CarregarOutrosNomes();
            }
        }
    }
}
