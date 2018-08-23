using RascalApp.UserControls;
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
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();

            //HD com a bar por cima
            System.Drawing.Rectangle rect = Screen.GetWorkingArea(this);
            this.MaximizedBounds = Screen.GetWorkingArea(this);
            this.WindowState = FormWindowState.Maximized;

            panelContainer.Controls.Add(new UserControlInicio());
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

        private void buttonInicio_MouseHover(object sender, EventArgs e)
        {
            buttonInicio.ForeColor = Color.Blue;
        }

        private void buttonInicio_MouseLeave(object sender, EventArgs e)
        {
            buttonInicio.ForeColor = Color.White;
        }

        private void buttonGaleria_MouseHover(object sender, EventArgs e)
        {
            buttonGaleria.ForeColor = Color.Blue;
        }

        private void buttonGaleria_MouseLeave(object sender, EventArgs e)
        {
            buttonGaleria.ForeColor = Color.White;
        }

        private void buttonNovoModelo_MouseHover(object sender, EventArgs e)
        {
            buttonNovoModelo.ForeColor = Color.Blue;
        }

        private void buttonNovoModelo_MouseLeave(object sender, EventArgs e)
        {
            buttonNovoModelo.ForeColor = Color.White;
        }

        private void buttonErmos_MouseHover(object sender, EventArgs e)
        {
            buttonErmos.ForeColor = Color.Blue;
        }

        private void buttonErmos_MouseLeave(object sender, EventArgs e)
        {
            buttonErmos.ForeColor = Color.White;
        }

        private void buttonOutras_MouseHover(object sender, EventArgs e)
        {
            buttonOutras.ForeColor = Color.Blue;
        }

        private void buttonOutras_MouseLeave(object sender, EventArgs e)
        {
            buttonOutras.ForeColor = Color.White;
        }

        private void buttonClubes_MouseHover(object sender, EventArgs e)
        {
            buttonClubes.ForeColor = Color.Blue;
        }

        private void buttonClubes_MouseLeave(object sender, EventArgs e)
        {
            buttonClubes.ForeColor = Color.White;
        }
    }
}
