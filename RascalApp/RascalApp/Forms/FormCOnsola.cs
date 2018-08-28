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
    public partial class FormCOnsola : Form
    {
        public FormCOnsola(List<ClassConsole> ListaDados)
        {
            InitializeComponent();
            CarregarConsola(ListaDados);
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CarregarConsola(List<ClassConsole> Dados)
        {
            listBoxConsole.Items.Clear();

            foreach(ClassConsole Cssl in Dados)
            {
                string consoleLinha = "RASCAL>>> " + Cssl.Texto + " | ";

                //Tempo

                TimeSpan tSpan = DateTime.Now - Cssl.Tempo;

                if (tSpan.Minutes < 1)
                {
                    if (tSpan.Seconds == 1)
                        consoleLinha += "Há " + tSpan.Seconds + " segundo";
                    else
                        consoleLinha += "Há " + tSpan.Seconds + " segundos";
                }
                else
                {
                    if(tSpan.Minutes == 1)
                        consoleLinha += "Há " + tSpan.Minutes + " minuto";
                    else
                        consoleLinha += "Há " + tSpan.Minutes + " minutos";
                }

                listBoxConsole.Items.Add(consoleLinha);
            }
        }
    }
}
