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
    public partial class UserControlNovaGaleria : UserControl
    {
        private FormInicio _FormInicio;
        private Modelo Esta;
        private List<string> CaminhosFotos;

        public UserControlNovaGaleria(FormInicio _formIni, Modelo _este)
        {
            InitializeComponent();

            _FormInicio = _formIni;
            Esta = _este;
            CaminhosFotos = new List<string>();
            CaminhosFotos.Clear();

            CarregarDados();
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            _FormInicio.MudarParaVerModelo(Esta);
        }

        private void CarregarDados()
        {
            //NOME
            labelModeloNome.Text = Esta.Nome;

            //FOTO
            byte[] buff = System.IO.File.ReadAllBytes(Esta.CaminhoFoto);
            using (System.IO.MemoryStream ms = new System.IO.MemoryStream(buff))
            {
                pictureBoxModeloPic.BackgroundImage = Image.FromStream(ms);
            }
        }

        private void buttonSelectFold_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Multiselect = true;
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";

            if (open.ShowDialog() == DialogResult.OK)
            {
                listViewNovaGaleria.Items.Clear();
                CaminhosFotos.Clear();

                ImageList ListaImagens = new ImageList();
                ListaImagens.ImageSize = new Size(230, 230);
                ListaImagens.ColorDepth = ColorDepth.Depth32Bit;

                int contador = 0;

                foreach (String file in open.FileNames)
                {
                    byte[] buff = System.IO.File.ReadAllBytes(file);
                    using (System.IO.MemoryStream ms = new System.IO.MemoryStream(buff))
                    {
                        ListaImagens.Images.Add("img" + contador, Funcionalidades.getThumbnaiImage(Image.FromStream(ms)));
                        contador++;
                    }                    
                }

                listViewNovaGaleria.View = View.LargeIcon;
                listViewNovaGaleria.LargeImageList = ListaImagens;
                contador = 0;

                foreach (String file in open.FileNames)
                {
                    ListViewItem lst = new ListViewItem();
                    lst.ImageIndex = 0;
                    lst.ImageKey = "img" + contador;
                    listViewNovaGaleria.Items.Add(lst);

                    CaminhosFotos.Add(file);

                    contador++;
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //NOME
            if(String.IsNullOrEmpty(textBoxNovaDesignacao.Text) || textBoxNovaDesignacao.Text == " ")
            {
                _FormInicio.EscreverNaConsola("Nome em falta!");
                return;
            }

            //FOTOS
            if(CaminhosFotos.Count < 2)
            {
                _FormInicio.EscreverNaConsola("Fotos em falta!");
                return;
            }

            //Guardar Nova Galeria
            DateTime _SaveTimeGal;

            try
            {
                //Guardar Galeria
                _SaveTimeGal = Funcionalidades.NovaGaleria(Esta.ID, 1, textBoxNovaDesignacao.Text);
            }
            catch
            {
                _FormInicio.EscreverNaConsola("Erro ao guardar a galeria!");
                return;
            }

            try
            {
                //Guardar Fotos da Galeria
                string nomeFolder = Funcionalidades.NomeLimpo(textBoxNovaDesignacao.Text);

                int index_ = 0;
                foreach (string path_ in CaminhosFotos)
                {
                    Funcionalidades.GuardarNovaGaleriaFoto(Funcionalidades.BuscarUltimaGaleria(_SaveTimeGal, Esta.ID).ID, textBoxNovaDesignacao.Text, Esta, path_, index_);
                    index_++;
                }
            }
            catch
            {
                _FormInicio.EscreverNaConsola("Erro ao guardar fotos!");
                return;
            }

            //Limpar Form
            _FormInicio.EscreverNaConsola("Nova galeria registada!");
            textBoxNovaDesignacao.Clear();
            listViewNovaGaleria.Items.Clear();
            CaminhosFotos.Clear();
        }
    }
}
 