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
    public partial class UserControlOutras : UserControl
    {
        FormInicio _FormInicio;
        List<Outras> ListaOutras;

        public UserControlOutras(FormInicio formInicio)
        {
            InitializeComponent();

            _FormInicio = formInicio;
            ListaOutras = new List<Outras>();

            CarregarOutras();
        }

        private void pictureBoxAddOutras_Click(object sender, EventArgs e)
        {
            FormAdicionarOutras PopupAddFotos = new FormAdicionarOutras(_FormInicio);
            DialogResult resultado = PopupAddFotos.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                try
                {
                    //Guardar novas outras
                    foreach (string str in PopupAddFotos.CaminhoFotos)
                    {
                        Funcionalidades.GuardarNovaOutra(str);
                    }

                    _FormInicio.EscreverNaConsola("Adicionadas " + PopupAddFotos.CaminhoFotos.Count() + " fotos!");

                    CarregarOutras();
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    Console.WriteLine(ex.Message);
                    _FormInicio.EscreverNaConsola("Erro ao guardar outras!");
                }
            }
        }

        private void CarregarOutras()
        {
            listViewOutras.Items.Clear();

            try
            {
                //Listas das outras
                ListaOutras = Funcionalidades.BuscarOutras();

                ImageList ListaImagens = new ImageList();
                ListaImagens.ImageSize = new Size(256, 256);
                ListaImagens.ColorDepth = ColorDepth.Depth32Bit;

                int contador = 0;

                foreach (Outras trs in ListaOutras)
                {
                    byte[] buff = System.IO.File.ReadAllBytes(trs.CaminhoFoto);
                    using (System.IO.MemoryStream ms = new System.IO.MemoryStream(buff))
                    {
                        ListaImagens.Images.Add("IMG" + contador, Funcionalidades.getThumbnaiImage(Image.FromStream(ms)));
                    }

                    contador++;
                }

                listViewOutras.View = View.LargeIcon;
                listViewOutras.LargeImageList = ListaImagens;

                contador = 0;

                foreach (Outras trs in ListaOutras)
                {
                    ListViewItem lst = new ListViewItem();
                    lst.ImageIndex = 0;
                    lst.ImageKey = "IMG" + contador;
                    listViewOutras.Items.Add(lst);

                    contador++;
                }

                labelContadorOutras.Text = ListaOutras.Count().ToString();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                _FormInicio.EscreverNaConsola("Erro ao carregar as outras...");
                return;
            }
        }

        private void listViewOutras_DoubleClick(object sender, EventArgs e)
        {
            if (listViewOutras.SelectedIndices.Count <= 0)
                return;

            int _ID = Convert.ToInt32(listViewOutras.GetSelectedItem().Tag);

            FormVerImagem _VerPic = new FormVerImagem(_ID, 3);

            _VerPic.Show();

        }
    }
}
