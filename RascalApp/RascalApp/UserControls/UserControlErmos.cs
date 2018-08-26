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

namespace RascalApp.UserControls
{
    public partial class UserControlErmos : UserControl
    {
        private FormInicio _FormInicio;

        public UserControlErmos(FormInicio _ini)
        {
            InitializeComponent();

            _FormInicio = _ini;
        }

        private void pictureBoxAddErmo_Click(object sender, EventArgs e)
        {
            FormAdicionarErmo _novoErmo = new FormAdicionarErmo(_FormInicio);
            _novoErmo.ShowDialog();
        }
    }
}
