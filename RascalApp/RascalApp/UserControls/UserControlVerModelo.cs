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

namespace RascalApp.UserControls
{
    public partial class UserControlVerModelo : UserControl
    {
        private FormInicio _FormInicio;
        private Modelo EsteModelo;

        public UserControlVerModelo(FormInicio _formIni, Modelo _este)
        {
            InitializeComponent();

            _FormInicio = _formIni;
            EsteModelo = _este;

            CarregarDados();
        }

        private void UserControlVerModelo_Load(object sender, EventArgs e)
        {

        }

        private void CarregarDados()
        {
            labelModeloNome.Text = EsteModelo.Nome;
            labelModeloVisualizacoes.Text = EsteModelo.Visualizacoes + " visualizações";

            //FOTO
            byte[] buff = System.IO.File.ReadAllBytes(EsteModelo.CaminhoFoto);
            using (System.IO.MemoryStream ms = new System.IO.MemoryStream(buff))
            {
                pictureBoxModeloPic.BackgroundImage = Image.FromStream(ms);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
