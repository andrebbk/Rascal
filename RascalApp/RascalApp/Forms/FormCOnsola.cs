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

            if(Dados.Count < 1)
            {
                listBoxConsole.Items.Add("Sem registos...");
                return;
            }

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

        private void listBoxConsole_DrawItem(object sender, DrawItemEventArgs e)
        {
            //DrawMode = OwnerDrawFixed para mudar a altura dos items (precisamos tbm deste bloco)

            e.DrawBackground();
            if (e.State == DrawItemState.Focus)
                e.DrawFocusRectangle();
            var index = e.Index;
            if (index < 0 || index >= listBoxConsole.Items.Count) return;
            var item = listBoxConsole.Items[index];
            string text = (item == null) ? "(null)" : item.ToString();

            if(text.ToLower().Contains("erro"))
            {
                using (var brush = new SolidBrush(Color.Red))
                {
                    e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
                    e.Graphics.DrawString(text, e.Font, brush, e.Bounds);
                }
            }
            else
            {
                using (var brush = new SolidBrush(e.ForeColor))
                {
                    e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
                    e.Graphics.DrawString(text, e.Font, brush, e.Bounds);
                }
            }            

            //Ate Aqui
        }
    }
}
