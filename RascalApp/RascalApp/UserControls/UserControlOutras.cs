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
    public partial class UserControlOutras : UserControl
    {
        FormInicio _FormInicio;

        public UserControlOutras(FormInicio formInicio)
        {
            InitializeComponent();

            _FormInicio = formInicio;
        }

        private void pictureBoxAddOutras_Click(object sender, EventArgs e)
        {
            FormAdicionarOutras PopupAddFotos = new FormAdicionarOutras(_FormInicio);
            DialogResult resultado = PopupAddFotos.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                try
                {
                    //Guardar novas outras
                    foreach (string str in PopupAddFotos.CaminhoFotos)
                    {
                        Funcionalidades.GuardarNovaOutra(str);
                    }

                    _FormInicio.EscreverNaConsola("Adicionadas " + PopupAddFotos.CaminhoFotos.Count() + " fotos!");
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    Console.WriteLine(ex.Message);
                    _FormInicio.EscreverNaConsola("Erro ao guardar outras!");
                }
            }
        }

        private void CarregarOutras()
        {

        }
    }
}
