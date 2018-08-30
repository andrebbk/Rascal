using RascalApp.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RascalApp
{
    public partial class FormSeguranca : Form
    {
        public FormSeguranca()
        {
            InitializeComponent();
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

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //LIMITAR SO A NUMEROS
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void pictureBoxButtonQuit_Click(object sender, EventArgs e)
        {
            //Sair
            Application.Exit();
        }

        private void pictureBoxButtonMinimize_Click(object sender, EventArgs e)
        {
            //Minimizar
            this.WindowState = FormWindowState.Minimized;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text.Length == 4)
            {
                if (Funcionalidades.MD5Hash(textBox1.Text) == Funcionalidades.MD5Hash("3302"))
                {
                    this.Hide();
                    FormInicio _Ini = new FormInicio();
                    _Ini.ShowDialog();
                    this.Close();
                }
                    
            }
        }
    }
}
