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
using System.IO;

namespace RascalApp.UserControls
{
    public partial class UserControlErmos : UserControl
    {
        private FormInicio _FormInicio;
        private List<Ermo> ListaErmos;

        public UserControlErmos(FormInicio _ini)
        {
            InitializeComponent();

            _FormInicio = _ini;
            ListaErmos = new List<Ermo>();

            CarregarErmos();
        }

        private void pictureBoxAddErmo_Click(object sender, EventArgs e)
        {
            FormAdicionarErmo _novoErmo = new FormAdicionarErmo(_FormInicio);            
            DialogResult resultado = _novoErmo.ShowDialog();

            if(resultado == DialogResult.Cancel)
            {
                if (_novoErmo.AtualizarLista)
                    CarregarErmos();
            }
        }

        private void CarregarErmos()
        {           
            listViewErmos.Items.Clear();
            ListaErmos.Clear();

            try
            {
                //Listas de clubes
                ListaErmos = Funcionalidades.BuscarErmos();

                ImageList ListaImagens = new ImageList();
                ListaImagens.ImageSize = new Size(256, 256);
                ListaImagens.ColorDepth = ColorDepth.Depth32Bit;

                foreach (Ermo rm in ListaErmos)
                {
                    string[] rmImagens = Directory.GetFiles("E:\\Rascal\\Ermos\\" + Funcionalidades.RemoveWhitespace(rm.Designacao));
                    byte[] buff = System.IO.File.ReadAllBytes(rmImagens[0]);

                    using (System.IO.MemoryStream ms = new System.IO.MemoryStream(buff))
                    {
                        ListaImagens.Images.Add(rm.Designacao, Funcionalidades.getThumbnaiImage(Image.FromStream(ms)));
                    }
                }

                listViewErmos.View = View.LargeIcon;
                listViewErmos.LargeImageList = ListaImagens;

                foreach (Ermo rm in ListaErmos)
                {
                    ListViewItem lst = new ListViewItem();
                    lst.Text = rm.Designacao;
                    lst.ImageIndex = 0;
                    lst.Tag = rm.ID;
                    lst.ImageKey = rm.Designacao;
                    listViewErmos.Items.Add(lst);
                }

                if (ListaErmos.Count() == 1)
                    labelContadorErmos.Text = "1";
                else
                    labelContadorErmos.Text = ListaErmos.Count().ToString();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine(ex.Message);
                _FormInicio.EscreverNaConsola("Erro ao carregar os Ermos!");                
            }
        }

        private void pictureBoxButtonResetErmos_Click(object sender, EventArgs e)
        {
            if (ListaErmos.Count < 1)
                return;

            FormPopUp PopupConfirmation = new FormPopUp("Tem a certeza que pertende continuar?");
            DialogResult resultado = PopupConfirmation.ShowDialog();

            if (resultado == DialogResult.Yes)
            {
                try
                {
                    Funcionalidades.ApagarTodosErmos();
                }
                catch
                {
                    _FormInicio.EscreverNaConsola("Erro ao eliminar os ermos...");
                }

                _FormInicio.EscreverNaConsola("Ermos elimidados!");
                CarregarErmos();
            }
        }

        private void listViewErmos_DoubleClick(object sender, EventArgs e)
        {
            if (listViewErmos.SelectedIndices.Count <= 0)
                return;

            int _ID = Convert.ToInt32(listViewErmos.GetSelectedItem().Tag);

            //Se for para abrir
            if (!_FormInicio.VerificarEditarInstrucao())
                return;

            foreach (Ermo rm in ListaErmos)
            {
                if (rm.ID == _ID)
                {
                    FormEditarErmo PopupEditar = new FormEditarErmo(rm.Designacao);
                    DialogResult resultado = PopupEditar.ShowDialog();

                    if (resultado == DialogResult.OK)
                    {
                        string NovoNome = PopupEditar.NomeEditado;

                        //Verificar se os dados foram editados
                        if (NovoNome == rm.Designacao)
                            return;

                        //Editar
                        if (!String.IsNullOrEmpty(NovoNome))
                        {
                            Funcionalidades.EditarErmo(NovoNome, rm);
                            _FormInicio.EscreverNaConsola("Ermo editado!");
                            CarregarErmos();
                        }

                    }
                    else if (resultado == DialogResult.Ignore)
                    {
                        //Apagar
                        FormPopUp PopupConfirmation = new FormPopUp("Tem a certeza que pertende continuar?");
                        DialogResult resultadoPopup = PopupConfirmation.ShowDialog();

                        if (resultadoPopup == DialogResult.Yes)
                        {
                            try
                            {
                                Funcionalidades.EliminarErmo(rm);
                                _FormInicio.EscreverNaConsola("Ermo eliminado!");
                                CarregarErmos();
                            }
                            catch
                            {
                                _FormInicio.EscreverNaConsola("Erro ao eliminar o Ermo...");
                            }

                        }

                    }

                    break;
                }
            }
        }
    }
}
