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
    public partial class UserControlDesconhecidos : UserControl
    {
        private FormInicio _FormInicio;

        public UserControlDesconhecidos(FormInicio _fIni)
        {
            InitializeComponent();

            _FormInicio = _fIni;
        }

        private void pictureBoxAddAnonima_Click(object sender, EventArgs e)
        {

        }
    }
}
