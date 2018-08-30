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
using RascalApp.Properties;
using System.IO;

namespace RascalApp.UserControls
{
    public partial class UserControlVerModelo : UserControl
    {
        private FormInicio _FormInicio;
        private Modelo EsteModelo;
        List<Galeria> _listaGalerias;
        List<PertenceA> _listaAssociacoes;
        List<Clube> _listaClubes;

        public UserControlVerModelo(FormInicio _formIni, Modelo _este)
        {
            InitializeComponent();

            _FormInicio = _formIni;
            EsteModelo = _este;
            _listaGalerias = new List<Galeria>();
            _listaAssociacoes = new List<PertenceA>();
            _listaClubes = new List<Clube>();

            CarregarDados();

            //Aumentar visualizacoes deste modelo
            Funcionalidades.AumentarModeloVisu(EsteModelo.ID, EsteModelo.Visualizacoes + 1);
        }

        private void UserControlVerModelo_Load(object sender, EventArgs e)
        {

        }

        private void CarregarGalerias()
        {
            listViewGaleriasDela.Items.Clear();
            _listaGalerias.Clear();

            try
            {
                //Listas de clubes
                _listaGalerias = Funcionalidades.BuscarGaleriasDELA(EsteModelo.ID);

                ImageList ListaImagens = new ImageList();
                ListaImagens.ImageSize = new Size(256, 256);
                ListaImagens.ColorDepth = ColorDepth.Depth32Bit;

                foreach (Galeria glr in _listaGalerias)
                {
                    List<Foto> _Fotos = Funcionalidades.BuscarFotosGaleria(glr.ID);

                    try
                    {
                        if (_Fotos.Count() > 0)
                        {
                            byte[] buff = System.IO.File.ReadAllBytes(_Fotos[0].CaminhoFoto);

                            using (System.IO.MemoryStream ms = new System.IO.MemoryStream(buff))
                            {
                                ListaImagens.Images.Add(glr.Designacao, Funcionalidades.getThumbnaiImage(Image.FromStream(ms)));
                            }
                        }
                        else
                        {
                            ListaImagens.Images.Add(glr.Designacao, Funcionalidades.getThumbnaiImage(Resources.no_photo));
                        }
                    }
                    catch
                    {
                        _FormInicio.EscreverNaConsola(glr.Designacao + " sem fotos");
                        ListaImagens.Images.Add(glr.Designacao, Funcionalidades.getThumbnaiImage(Resources.no_photo));
                    }                                        
                }

                listViewGaleriasDela.View = View.LargeIcon;
                listViewGaleriasDela.LargeImageList = ListaImagens;

                foreach (Galeria glr in _listaGalerias)
                {
                    ListViewItem lst = new ListViewItem();
                    lst.Text = glr.Designacao;
                    lst.ImageIndex = 0;
                    lst.Tag = glr.ID;
                    lst.ImageKey = glr.Designacao;
                    listViewGaleriasDela.Items.Add(lst);
                }

                if (_listaGalerias.Count() == 1)
                    labelModeloNGalerias.Text = "1 galeria";
                else
                    labelModeloNGalerias.Text = _listaGalerias.Count().ToString() + " galerias";

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine(ex.Message);
                _FormInicio.EscreverNaConsola("Erro ao carregar galerias!");
            }
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

            //GALERIAS
            CarregarGalerias();

            //CLUBES
            CarregarClubes();

            //OUTROS NOMES
            CarregarOutrosNomes();

            //N Galerias e N Fotos
            QuantasGaleriasEFotos();
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

            if (_listaAssociacoes.Count == 1)
                labelModeloNClubes.Text = "1 clube";
            else
                labelModeloNClubes.Text = _listaAssociacoes.Count + " clubes";

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

        private void QuantasGaleriasEFotos()
        {
            int NGalerias = 0;
            int NFotos = 1;

            List<Galeria> _galerias = Funcionalidades.BuscarGaleriasDELA(EsteModelo.ID);
            NGalerias = _galerias.Count;

            foreach(Galeria glr in _galerias)
            {
                List<Foto> _fotos = Funcionalidades.BuscarFotosGaleria(glr.ID);
                NFotos += _fotos.Count;
            }

            if (NFotos == 1)
                labelModeloNFotos.Text = "1 foto";
            else
                labelModeloNFotos.Text = NFotos + " fotos";

            if (NGalerias == 1)
                labelModeloNGalerias.Text = "1 galeria";
            else
                labelModeloNGalerias.Text = NGalerias + " galerias";
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

        private void buttonModeloEditar_Click(object sender, EventArgs e)
        {
            FormEditarModelo PopupEditar = new FormEditarModelo(EsteModelo, false, _FormInicio);
            DialogResult resultado = PopupEditar.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                string NovoNome = PopupEditar.NomeEditado;
                string NovaFoto = PopupEditar.FotoEditada;

                //Verificar se os dados foram editados
                if (NovoNome == EsteModelo.Nome && NovaFoto == EsteModelo.CaminhoFoto)
                {
                    if (PopupEditar.atualizar)
                        CarregarGalerias();

                    return;
                }
                    

                //Editar
                if ((!String.IsNullOrEmpty(NovoNome) && NovoNome != EsteModelo.Nome) || (!String.IsNullOrEmpty(NovaFoto) && NovaFoto != EsteModelo.CaminhoFoto))
                {
                    Funcionalidades.EditarModelo(NovoNome, NovaFoto, EsteModelo);
                    _FormInicio.EscreverNaConsola(NovoNome + " editado!");

                    EsteModelo = Funcionalidades.BuscarModelo(EsteModelo.ID);
                    CarregarDados();
                }
            }
        }

        private void buttonModeloApagar_Click(object sender, EventArgs e)
        {
            //Apagar
            FormPopUp PopupConfirmation = new FormPopUp("Tem a certeza que pertende continuar?");
            DialogResult resultadoPopup = PopupConfirmation.ShowDialog();

            if (resultadoPopup == DialogResult.Yes)
            {
                try
                {
                    Funcionalidades.EliminarModelo(EsteModelo);
                    _FormInicio.EscreverNaConsola(EsteModelo.Nome + " eliminado!");
                    _FormInicio.MudarParaAGaleria();
                }
                catch
                {
                    _FormInicio.EscreverNaConsola("Erro ao eliminar o Modelo!");
                }

            }
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            _FormInicio.MudarParaAGaleria();
        }

        private void buttonModeloAddGalerias_Click(object sender, EventArgs e)
        {
            _FormInicio.MudarParaAdicionarGalerias(EsteModelo);
        }
    }
}
