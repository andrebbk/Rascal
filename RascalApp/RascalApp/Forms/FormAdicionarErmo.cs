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
    public partial class FormAdicionarErmo : Form
    {
        private FormInicio _FormInicio;
        private List<string> CaminhoFotos;

        public FormAdicionarErmo(FormInicio _formIni)
        {
            InitializeComponent();

            CaminhoFotos = new List<string>();
            _FormInicio = _formIni;
        }

        //Form drag
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        //Form drag
        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;

        private void buttonCarregarFotos_Click(object sender, EventArgs e)
        {
            //Mudar foto
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Multiselect = true;
                open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";

                if (open.ShowDialog() == DialogResult.OK)
                {
                    listViewNovoErmo.Items.Clear();
                    CaminhoFotos.Clear();

                    ImageList ListaImagens = new ImageList();
                    ListaImagens.ImageSize = new Size(256, 190);
                    ListaImagens.ColorDepth = ColorDepth.Depth32Bit;

                    int contador = 0;

                    foreach (String files in open.FileNames)
                    {
                        byte[] buff = System.IO.File.ReadAllBytes(files);
                        using (System.IO.MemoryStream ms = new System.IO.MemoryStream(buff))
                        {
                            ListaImagens.Images.Add("img" + contador, Image.FromStream(ms));
                            contador++;
                        }
                    }

                    listViewNovoErmo.View = View.LargeIcon;
                    listViewNovoErmo.LargeImageList = ListaImagens;
                    contador = 0;

                    foreach (String files in open.FileNames)
                    {
                        ListViewItem lst = new ListViewItem();
                        lst.ImageIndex = 0;
                        lst.ImageKey = "img" + contador;
                        listViewNovoErmo.Items.Add(lst);

                        CaminhoFotos.Add(files);

                        contador++;
                    }

                  }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine(ex.Message);
                _FormInicio.EscreverNaConsola("Erro ao carregar as fotos!");
            }
            
            
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(textBoxDesignacao.Text) || textBoxDesignacao.Text == " ")
            {
                _FormInicio.EscreverNaConsola("Designação em falta!");
                return;
            }

            if(CaminhoFotos.Count() < 1)
            {
                _FormInicio.EscreverNaConsola("Fotos em falta!");
                return;
            }

            //Novo ermo
            Ermo _EsteErmo = new Ermo();

            try
            {
                //Registar novo ermo + Buscar ermo registado
                DateTime XAgora = Funcionalidades.GuardarNovoErmo(textBoxDesignacao.Text);
                _EsteErmo = Funcionalidades.BuscarUltimoErmo(XAgora);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine(ex.Message);
                _FormInicio.EscreverNaConsola("Erro ao registar o novo Ermo!");
            }
            
            try
            {
                int contador = 0;

                //Guardar novas fotos no  _EsteErmo
                foreach (string str in CaminhoFotos)
                {
                    Funcionalidades.GuardarNovaErmoFoto(_EsteErmo, str, contador);
                    contador++;
                }

                _FormInicio.EscreverNaConsola("Ermo registado com " + contador + " fotos!");
                listViewNovoErmo.Items.Clear();
                textBoxDesignacao.Clear();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine(ex.Message);
                _FormInicio.EscreverNaConsola("Erro ao guardar o novo Ermo!");
            }
        }
    }
}
