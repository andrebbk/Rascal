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
using System.IO;

namespace RascalApp.UserControls
{
    public partial class UserControlNovasGalerias : UserControl
    {
        private FormInicio _FormInicio;
        private Modelo EsteModelo;
        private string Caminho;
        private List<ngModel> ListaDados;

        public UserControlNovasGalerias(FormInicio _formI, Modelo Este_)
        {
            InitializeComponent();

            _FormInicio = _formI;
            EsteModelo = Este_;
            ListaDados = new List<ngModel>();

            panelShowDirectory.Hide();
        }

        private void buttonCarregarFotos_Click(object sender, EventArgs e)
        {
            OpenFileDialog folderBrowser = new OpenFileDialog();

            folderBrowser.ValidateNames = false;
            folderBrowser.CheckFileExists = false;
            folderBrowser.CheckPathExists = true;

            // Always default to Folder Selection.
            folderBrowser.FileName = "Folder Selection.";

            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                Caminho = folderBrowser.FileName.Replace("Folder Selection", "");
                labelCaminho.Text = folderBrowser.FileName.Replace("Folder Selection", "");
                CarregarLista();
            }

            panelShowDirectory.Show();

        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            _FormInicio.MudarParaVerModelo(EsteModelo);
        }

        private void CarregarLista()
        {
            listViewNovasGalerias.Items.Clear();

            try
            {
                OrganizarDados();

                ImageList ListaImagens = new ImageList();
                ListaImagens.ImageSize = new Size(256, 256);
                ListaImagens.ColorDepth = ColorDepth.Depth32Bit;

                foreach (ngModel ngM in ListaDados)
                {
                    byte[] buff = System.IO.File.ReadAllBytes(ngM.caminhoFotos.FirstOrDefault());

                    using (System.IO.MemoryStream ms = new System.IO.MemoryStream(buff))
                    {
                        ListaImagens.Images.Add(ngM.NomeGal, Funcionalidades.getThumbnaiImage(Image.FromStream(ms)));
                    }
                }


                //listViewNovasGalerias.View = View.Details;
                listViewNovasGalerias.LargeImageList = ListaImagens;
                listViewNovasGalerias.SmallImageList = ListaImagens;

                listViewNovasGalerias.Columns.Add("Item Column", -2, HorizontalAlignment.Left);
                listViewNovasGalerias.Columns.Add("Column 2", -2, HorizontalAlignment.Left);

                foreach (ngModel ngM in ListaDados)
                {
                    ListViewItem lst = new ListViewItem();
                    lst.Text = ngM.NomeGal;
                    lst.ImageIndex = 0;
                    lst.ImageKey = ngM.NomeGal;
                    listViewNovasGalerias.Items.Add(lst);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine(ex.Message);
                _FormInicio.EscreverNaConsola("Erro ao carregar novas galerias!");
            }

            if (ListaDados.Count < 1)
                panelShowDirectory.Hide();
            else
                panelShowDirectory.Show();
        }

        private void OrganizarDados()
        {
            ListaDados.Clear();

            string[] fotos = Directory.GetFiles(Caminho);

            foreach(string str in fotos)
            {
                if(Funcionalidades.IsPathImage(str))
                {
                    string[] parts = str.Split('\\');
                    string[] nome = parts[parts.Count() - 1].Split('.');

                    //Verificar se o nome é constituido so por numeros
                    int aux = 0;
                    if (!int.TryParse(nome[0], out aux))
                    {
                        _FormInicio.EscreverNaConsola("Erro nome numérico!");
                        return;
                    }

                    string NomeGal = Funcionalidades.BuscarNomeGaleria(nome[0]);
                    bool eIgual = false;

                    //Verificar se já existe
                    foreach(ngModel _m in ListaDados)
                    {
                        if(NomeGal == _m.NomeGal)
                        {
                            eIgual = true;
                            _m.caminhoFotos.Add(str);
                            break;
                        }
                    }

                    if (!eIgual)
                    {
                        ngModel _NovoModel = new ngModel();
                        _NovoModel.NomeGal = NomeGal;
                        _NovoModel.caminhoFotos.Add(str);
                        ListaDados.Add(_NovoModel);
                    }
                }                
            }
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if(ListaDados.Count < 1)
            {
                _FormInicio.EscreverNaConsola("Não existem galerias!");
                return;
            }

            FormGuardarNovasGalerias _Guardalas = new FormGuardarNovasGalerias(_FormInicio, ListaDados, EsteModelo);
            DialogResult resultado = _Guardalas.ShowDialog();

            if(resultado == DialogResult.OK)
            {
                CarregarLista();
            }
        }
    }
}
