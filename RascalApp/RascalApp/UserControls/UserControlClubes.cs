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
using System.IO;
using RascalApp.Properties;
using System.Drawing.Imaging;
using RascalApp.Models;

namespace RascalApp.UserControls
{
    public partial class UserControlClubes : UserControl
    {
        FormInicio _FormInicio;
        private string Foto = "nada";
        private List<Clube> listaCLubes;

        public UserControlClubes(FormInicio _formIni)
        {            
            InitializeComponent();            

            _FormInicio = _formIni;
            listaCLubes = new List<Clube>();

            CarregarListaClubes();

        }

        private void buttonRegistarClube_Click(object sender, EventArgs e)
        {
            //Nome
            if (String.IsNullOrEmpty(textBoxNovoNome.Text) || textBoxNovoNome.Text == " ")
            {
                _FormInicio.EscreverNaConsola("Nome em falta...");
                return;
            }

            //Fotografia
            if (Foto == "nada")
            {
                _FormInicio.EscreverNaConsola("Foto em falta...");
                return;
            }

            try
            {
                //Verificar diretório  dos clubes 
                if (!Directory.Exists("E:\\Rascal\\Clubes"))
                    Directory.CreateDirectory("E:\\Rascal\\Clubes");

                //Guardar Foto
                string[] parts = Foto.Split('.');
                string NovaFoto = "E:\\Rascal\\Clubes\\" + textBoxNovoNome.Text + "." + parts[parts.Count() - 1];
                File.Move(Foto, NovaFoto);

                //Registar novo clube
                Funcionalidades.GuardarNovoClube(textBoxNovoNome.Text, textBoxNovoNome.Text + "." + parts[parts.Count() - 1]);
            }
            catch (Exception ex)
            {
                _FormInicio.EscreverNaConsola("Erro ao registar o clube!");
                Console.WriteLine(ex.ToString());
                return;
            }

            _FormInicio.EscreverNaConsola(textBoxNovoNome.Text + " registado!");

            LimparFormNovoClube();

            //Refresh list view
            CarregarListaClubes();
        }

        private void LimparFormNovoClube()
        {
            pictureBoxNovaFota.BackgroundImage = Resources.if_HP_Pictures_Folder_Dock_512_17259;
            Foto = "nada";
            textBoxNovoNome.Clear();
        }

        private void pictureBoxNovaFota_Click(object sender, EventArgs e)
        {
            //Mudar foto

            OpenFileDialog open = new OpenFileDialog();
            open.Multiselect = false;
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";

            if (open.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(open.FileName, FileMode.Open, FileAccess.Read))
                {
                    pictureBoxNovaFota.BackgroundImage = Image.FromStream(stream);
                }

                Foto = open.FileName;
            }
        }

        private void CarregarListaClubes()
        {
            listViewClubes_.Items.Clear();

            try
            {
                //Listas de clubes
                listaCLubes = Funcionalidades.BuscarClubes();

                ImageList ListaImagens = new ImageList();
                ListaImagens.ImageSize = new Size(256, 190);
                ListaImagens.ColorDepth = ColorDepth.Depth32Bit;

                foreach (Clube clb in listaCLubes)
                {
                    byte[] buff = System.IO.File.ReadAllBytes("E:\\Rascal\\Clubes\\" + clb.NomeFoto);
                    using (System.IO.MemoryStream ms = new System.IO.MemoryStream(buff))
                    {
                        ListaImagens.Images.Add(clb.Nome, Image.FromStream(ms));
                    }
                }

                listViewClubes_.View = View.LargeIcon;
                listViewClubes_.LargeImageList = ListaImagens;

                foreach (Clube clb in listaCLubes)
                {
                    ListViewItem lst = new ListViewItem();
                    lst.Text = clb.Nome;
                    lst.Name = clb.Nome;
                    lst.Tag = clb.ID.ToString();
                    lst.ImageIndex = 0;
                    lst.ImageKey = clb.Nome;
                    listViewClubes_.Items.Add(lst);
                }                

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                _FormInicio.EscreverNaConsola("Erro ao carregar os clubes...");
                return;
            }           

        }

        private void pictureBoxButtonReset_Click(object sender, EventArgs e)
        {
            FormPopUp PopupConfirmation = new FormPopUp("Tem a certeza que pertende continuar?");
            DialogResult resultado = PopupConfirmation.ShowDialog();

            if (resultado == DialogResult.Yes)
            {
                try
                {
                    Funcionalidades.EliminarTodosClubes();
                }
                catch
                {
                    _FormInicio.EscreverNaConsola("Erro ao eliminar os clubes...");
                }

                _FormInicio.EscreverNaConsola("Clubes elimidados...");
                CarregarListaClubes();
            }
        }

        private void listViewClubes__DoubleClick(object sender, EventArgs e)
        {
            if (listViewClubes_.SelectedIndices.Count <= 0)
                return;

            int _ID = Convert.ToInt32(listViewClubes_.GetSelectedItem().Tag);

            foreach (Clube clb in listaCLubes)
            {
                if (clb.ID == _ID)
                {
                    FormEditarClube PopupEditar = new FormEditarClube(clb);
                    DialogResult resultado = PopupEditar.ShowDialog();

                    if (resultado == DialogResult.OK)
                    {                        
                        string NovoNome = PopupEditar.NomeEditado;
                        string NovaFoto = PopupEditar.FotoEditada;

                        //Verificar se os dados foram editados
                        if (NovoNome == "nop" && NovaFoto == "nop")
                            return;

                        string[] parts = NovaFoto.Split('\\');
                        if (clb.Nome == NovoNome && clb.NomeFoto == parts[parts.Count() - 1])
                            return;

                        //Editar

                        _FormInicio.EscreverNaConsola(textBoxNovoNome.Text + " editado!");
                        CarregarListaClubes();
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
                                Funcionalidades.EliminarClube(clb);
                                _FormInicio.EscreverNaConsola(textBoxNovoNome.Text + " eliminado!");
                                CarregarListaClubes();
                            }
                            catch
                            {
                                _FormInicio.EscreverNaConsola("Erro ao eliminar o clube...");
                            }
                           
                        }
                        
                    }

                    break;
                }
            }
        }
    }

    internal static class ListViewEx
    {
        internal static ListViewItem GetSelectedItem(this ListView listViewCLubes)
        {
            return (listViewCLubes.SelectedItems.Count > 0 ? listViewCLubes.SelectedItems[0] : null);
        }
    }

}
