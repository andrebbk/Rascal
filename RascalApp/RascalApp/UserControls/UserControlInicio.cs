using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using RascalApp.Forms;
using System.Threading;

namespace RascalApp.UserControls
{
    public partial class UserControlInicio : UserControl
    {
        private FormInicio _FormInicio;

        public UserControlInicio(FormInicio _fInit)
        {
            InitializeComponent();

            _FormInicio = _fInit;
            CarregarINFOdisco();
        }

        private void UserControlInicio_Load(object sender, EventArgs e)
        {

        }

        private void CarregarINFOdisco()
        {
            if (Directory.Exists("E:\\Rascal"))
            {
                //Nome
                labelDiscoNome.Text = "External Insys";            
                
                foreach (var drive in DriveInfo.GetDrives())
                {                   
                    if (Directory.Exists(drive.Name.Split(':')[0] + ":\\Rascal"))
                    {
                        //Diretorio
                        labelDiscoDiretorio.Text = drive.Name.Split(':')[0];

                        //Tipo
                        labelDiscoTipo.Text = drive.DriveFormat.ToUpper();

                        //Espaço Total
                        double totalSpace = drive.TotalSize;
                        totalSpace = (totalSpace / Math.Pow(1024, 3));
                        labelDiscoETotal.Text = totalSpace.ToString("0.") + " GB";

                        //Espaço Livre
                        double freeSpace = drive.TotalFreeSpace;
                        freeSpace = (freeSpace / Math.Pow(1024, 3));
                        labelDiscoELivre.Text = freeSpace.ToString("0.00") + " GB";
                        labelFreePercent.Text = (100 * (double)drive.TotalFreeSpace / drive.TotalSize).ToString("0.0") + "%";

                        //Espaço Ocupado
                        double usedsize = totalSpace - freeSpace;
                        labelDiscoEOcupado.Text = usedsize.ToString("0.00") + " GB";
                        labelUsedPercent.Text = (100 * (double)(drive.TotalSize - drive.TotalFreeSpace)/ drive.TotalSize).ToString("0.0") + "%";

                        break;
                    }
                }

                _FormInicio.BloquearInteracoes(true);
            }
            else
            {
                //Nome
                labelDiscoNome.Text = "N/A";

                //Diretorio
                labelDiscoDiretorio.Text = "N/A";

                //Tipo
                labelDiscoTipo.Text = "N/A";

                //Espaço Total
                labelDiscoETotal.Text = "N/A";

                //Espaço Livre
                labelDiscoELivre.Text = "N/A";
                labelFreePercent.Text = "";

                //Espaço Ocupado
                labelDiscoEOcupado.Text = "N/A";
                labelUsedPercent.Text = "";

                _FormInicio.BloquearInteracoes(false);

                Thread _Thread = new Thread(new ThreadStart(VerificarConecao));
                _Thread.IsBackground = true;
                _Thread.Start();
            }
        }

        private void VerificarConecao()
        {
            System.Threading.Thread.Sleep(5000);

            if (Directory.Exists("E:\\Rascal"))
            {
                Invoke((MethodInvoker)delegate {
                    CarregarINFOdisco();
                });
            }
            else
            {
                VerificarConecao();
            }                
        }

    }
}
