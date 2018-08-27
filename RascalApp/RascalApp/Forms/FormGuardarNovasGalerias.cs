using RascalApp.Models;
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
    public partial class FormGuardarNovasGalerias : Form
    { 
        private FormInicio _FormInicio;
        private List<ngModel> ListaDados;
        private Modelo EsteModelo;

        public FormGuardarNovasGalerias(FormInicio _fomrInit, List<ngModel> _dados, Modelo _este)
        {
            InitializeComponent();

            _FormInicio = _fomrInit;
            ListaDados = _dados;
            EsteModelo = _este;
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {

        }
    }
}
