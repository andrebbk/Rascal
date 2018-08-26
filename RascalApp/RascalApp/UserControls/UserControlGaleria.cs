using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RascalApp.Forms;
using RascalApp.Models;

namespace RascalApp.UserControls
{
    public partial class UserControlGaleria : UserControl
    {
        private FormInicio _FormInicio;
        private List<Modelo> ListaModelos;

        public UserControlGaleria(FormInicio _Fornini)
        {
            InitializeComponent();

            _FormInicio = _Fornini;
            ListaModelos = new List<Modelo>();

            CarregarModelos();
        }

        private void UserControlGaleria_Load(object sender, EventArgs e)
        {

        }

        private void CarregarModelos()
        {
            listViewGaleria.Items.Clear();
            ListaModelos.Clear();

            try
            {
                //Listas de clubes
                ListaModelos = Funcionalidades.BuscarModelos();

                ImageList ListaImagens = new ImageList();
                ListaImagens.ImageSize = new Size(256, 190);
                ListaImagens.ColorDepth = ColorDepth.Depth32Bit;

                foreach (Modelo mdl in ListaModelos)
                {
                    byte[] buff = System.IO.File.ReadAllBytes(mdl.CaminhoFoto);

                    using (System.IO.MemoryStream ms = new System.IO.MemoryStream(buff))
                    {
                        ListaImagens.Images.Add(mdl.Nome, Image.FromStream(ms));
                    }
                }

                listViewGaleria.View = View.LargeIcon;
                listViewGaleria.LargeImageList = ListaImagens;

                foreach (Modelo mdl in ListaModelos)
                {
                    ListViewItem lst = new ListViewItem();
                    lst.Text = mdl.Nome;
                    lst.ImageIndex = 0;
                    lst.Tag = mdl.ID;
                    lst.ImageKey = mdl.Nome;
                    listViewGaleria.Items.Add(lst);
                }

                if (ListaModelos.Count() == 1)
                    labelContadorModelos.Text = "1";
                else
                    labelContadorModelos.Text = ListaModelos.Count().ToString();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine(ex.Message);
                _FormInicio.EscreverNaConsola("Erro ao carregar os Modelos!");
            }
        }
    }
}
