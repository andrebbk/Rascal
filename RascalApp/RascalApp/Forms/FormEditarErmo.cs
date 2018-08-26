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
    public partial class FormEditarErmo : Form
    {
        public string NomeEditado;

        public FormEditarErmo(string des)
        {
            InitializeComponent();
            NomeEditado = des;

            textBoxNovoNome.Text = des;
        }

        private void FormEditarErmo_Load(object sender, EventArgs e)
        {

        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            NomeEditado = textBoxNovoNome.Text;
        }
    }
}
