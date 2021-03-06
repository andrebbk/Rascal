﻿using System;
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
    public partial class FormAddAnonimas : Form
    {
        public List<string> CaminhoFotos;

        public FormAddAnonimas()
        {
            InitializeComponent();
            CaminhoFotos = new List<string>();
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
            OpenFileDialog open = new OpenFileDialog();
            open.Multiselect = true;
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";

            if (open.ShowDialog() == DialogResult.OK)
            {
                listViewNovasAnonimas.Items.Clear();
                CaminhoFotos.Clear();

                ImageList ListaImagens = new ImageList();
                ListaImagens.ImageSize = new Size(256, 256);
                ListaImagens.ColorDepth = ColorDepth.Depth32Bit;

                int contador = 0;

                foreach (String files in open.FileNames)
                {
                    byte[] buff = System.IO.File.ReadAllBytes(files);
                    using (System.IO.MemoryStream ms = new System.IO.MemoryStream(buff))
                    {
                        ListaImagens.Images.Add("img" + contador, Funcionalidades.getThumbnaiImage(Image.FromStream(ms)));
                        contador++;
                    }
                }

                listViewNovasAnonimas.View = View.LargeIcon;
                listViewNovasAnonimas.LargeImageList = ListaImagens;
                contador = 0;

                foreach (String files in open.FileNames)
                {
                    ListViewItem lst = new ListViewItem();
                    lst.ImageIndex = 0;
                    lst.ImageKey = "img" + contador;
                    listViewNovasAnonimas.Items.Add(lst);

                    CaminhoFotos.Add(files);

                    contador++;
                }

            }
        }
    }
}
