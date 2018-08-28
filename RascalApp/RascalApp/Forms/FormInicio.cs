using RascalApp.Models;
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
        private bool EParaEditar;
        private List<ClassConsole> ListaCONSOLA;

        public FormInicio()
        {
            InitializeComponent();

            //HD com a bar por cima
            System.Drawing.Rectangle rect = Screen.GetWorkingArea(this);
            this.MaximizedBounds = Screen.GetWorkingArea(this);
            this.WindowState = FormWindowState.Maximized;

            panelContainer.Controls.Add(new UserControlInicio());

            EParaEditar = false;

            ListaCONSOLA = new List<ClassConsole>(); 

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

        //BOTOES HOVER/LEAVE
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
        //BOTOES HOVER/LEAVE

        private void buttonNovoModelo_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(new UserControlNovoModelo(this));
        }

        private void buttonInicio_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(new UserControlInicio());
        }

        private void buttonClubes_Click(object sender, EventArgs e)
        {
            try
            {
                panelContainer.Controls.Clear();
                panelContainer.Controls.Add(new UserControlClubes(this));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine(ex.Message);
                EscreverNaConsola("Erro ao entrar nos Clubes!");
            }

        }

        private void buttonOutras_Click(object sender, EventArgs e)
        {
            try
            {
                panelContainer.Controls.Clear();
                panelContainer.Controls.Add(new UserControlOutras(this));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine(ex.Message);
                EscreverNaConsola("Erro ao entrar nas Outras!");
            }
        }

        private void buttonErmos_Click(object sender, EventArgs e)
        {
            try
            {
                panelContainer.Controls.Clear();
                panelContainer.Controls.Add(new UserControlErmos(this));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine(ex.Message);
                EscreverNaConsola("Erro ao entrar nos Ermos!");
            }
        }

        private void buttonGaleria_Click(object sender, EventArgs e)
        {
            MudarParaAGaleria();
        }

        private void pictureBoxEditarCOisas_Click(object sender, EventArgs e)
        {
            EParaEditar = !EParaEditar;

            if (EParaEditar)
                pictureBoxEditarCOisas.BorderStyle = BorderStyle.Fixed3D;
            else
                pictureBoxEditarCOisas.BorderStyle = BorderStyle.None;
        }

        //METODOS PUBLICOS
        public void EscreverNaConsola(string texto)
        {
            labelConsola.Text = texto;
            ListaCONSOLA.Add(new ClassConsole { Texto = texto, Tempo = DateTime.Now });
        }

        public bool VerificarEditarInstrucao()
        {
            return EParaEditar;
        }

        public void MostrarModelo(Modelo x)
        {
            try
            {
                panelContainer.Controls.Clear();
                panelContainer.Controls.Add(new UserControlVerModelo(this, x));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine(ex.Message);
                EscreverNaConsola("Erro ao entrar no Modelo!");
            }
        }

        public void MudarParaAGaleria()
        {
            try
            {
                panelContainer.Controls.Clear();
                panelContainer.Controls.Add(new UserControlGaleria(this));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine(ex.Message);
                EscreverNaConsola("Erro ao entrar na Galeria!");
            }
        }

        public void MudarParaVerModelo(Modelo este)
        {
            try
            {
                panelContainer.Controls.Clear();
                panelContainer.Controls.Add(new UserControlVerModelo(this, este));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine(ex.Message);
                EscreverNaConsola("Erro ao entrar nas NovasGaleria!");
            }
        }

        public void MudarParaAdicionarGalerias(Modelo este)
        {
            try
            {
                panelContainer.Controls.Clear();
                panelContainer.Controls.Add(new UserControlNovasGalerias(this, este));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine(ex.Message);
                EscreverNaConsola("Erro ao entrar nas NovasGaleria!");
            }
        }

        private void labelopenConsola_Click(object sender, EventArgs e)
        {
            //Abrir Consola
            new FormCOnsola(ListaCONSOLA).Show();
        }
    }
}
