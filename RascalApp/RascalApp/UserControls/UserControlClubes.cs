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

        private void UserControlClubes_Load(object sender, EventArgs e)
        {

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
            listViewCLubes.View = View.LargeIcon;

            try
            {
                //Listas de clubes
                listaCLubes = Funcionalidades.BuscarClubes();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                _FormInicio.EscreverNaConsola("Erro ao carregar os clubes...");
                return;
            }

            ImageList ListaImagens = new ImageList();
            ListaImagens.ImageSize = new Size(192, 192);
            ListaImagens.ColorDepth = ColorDepth.Depth32Bit;

            foreach (Clube clb in listaCLubes)
            {
                ListaImagens.Images.Add(Bitmap.FromFile("E:\\Rascal\\Clubes\\" + clb.NomeFoto));
            }
            
            listViewCLubes.LargeImageList = ListaImagens;

            foreach (Clube clb in listaCLubes)
            {
                ListViewItem lst = new ListViewItem();
                lst.Text = clb.Nome;
                lst.ImageIndex = clb.ID;
                listViewCLubes.Items.Add(lst);
            }


        }

        private void listViewCLubes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewCLubes.SelectedIndices.Count <= 0)
                return;

            int _ID = listViewCLubes.GetSelectedItem().ImageIndex;
        }

        private void pictureBoxButtonReset_Click(object sender, EventArgs e)
        {
            FormPopUp PopupConfirmation = new FormPopUp("Tem a certeza que pertende continuar?");
            DialogResult resultado = PopupConfirmation.ShowDialog();

            if (resultado == DialogResult.Yes)
            {
                Funcionalidades.EliminarTodosClubes();
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
