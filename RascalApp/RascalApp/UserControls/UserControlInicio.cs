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
using System.Diagnostics;

namespace RascalApp.UserControls
{
    public partial class UserControlInicio : UserControl
    {
        private FormInicio _FormInicio;
        private bool lockedData;

        public UserControlInicio(FormInicio _fInit)
        {
            InitializeComponent();

            _FormInicio = _fInit;
            lockedData = true;
            CarregarINFOdisco();
            CarregarEstatisticas();
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

                lockedData = false;
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

                lockedData = true;
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

                    try
                    {
                        Funcionalidades.NovaAbertura();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                        Console.WriteLine(ex.Message);
                    }

                    CarregarINFOdisco();
                    CarregarEstatisticas();
                });
            }
            else
                VerificarConecao();
        }

        private void CarregarEstatisticas()
        {
            if(lockedData)
            {
                label2Modelos.Text = "-";
                label2Galerias.Text = "-";
                label2Fotos.Text = "-";
                label2Ermos.Text = "-";
                label2Outras.Text = "-";
                label2Clubes.Text = "-";
                label2Uso.Text = "-";
                label2Diretorios.Text = "-";
                label2Ficheiros.Text = "-";
            }
            else
            {
                //Modelos
                try
                {
                    label2Modelos.Text = Funcionalidades.QuantosModelos().ToString();
                }
                catch
                {
                    _FormInicio.EscreverNaConsola("Erro ao contar Modelos!");
                }                
                

                //Ermos
                try
                {
                    label2Ermos.Text = Funcionalidades.QuantosErmos().ToString();
                }
                catch
                {
                    _FormInicio.EscreverNaConsola("Erro ao contar Ermos!");
                }

                //Outras
                try
                {
                    label2Outras.Text = Funcionalidades.QuantasOutras().ToString();
                }
                catch
                {
                    _FormInicio.EscreverNaConsola("Erro ao contar Outras!");
                }

                //Clubes
                try
                {
                    label2Clubes.Text = Funcionalidades.QuantosClubes().ToString();
                }
                catch
                {
                    _FormInicio.EscreverNaConsola("Erro ao contar Clubes!");
                }

                //Fotos
                try
                {
                    label2Fotos.Text = Funcionalidades.QuantasFotos().ToString();
                }
                catch
                {
                    _FormInicio.EscreverNaConsola("Erro ao contar Fotos!");
                }

                //Galerias
                try
                {
                    label2Galerias.Text = Funcionalidades.QuantasGalerias().ToString();
                }
                catch
                {
                    _FormInicio.EscreverNaConsola("Erro ao contar galerias!");
                }

                //Uso
                try
                {
                    label2Uso.Text = Funcionalidades.QuantasAberturas().ToString();
                }
                catch
                {
                    _FormInicio.EscreverNaConsola("Erro ao contar a serventia!");
                }                

                //Contar ficheiros
                try
                {
                    int fCount = Directory.GetFiles("E:\\Rascal", "*", SearchOption.AllDirectories).Length;
                    int directoryCount = System.IO.Directory.GetDirectories("E:\\Rascal", "*", SearchOption.AllDirectories).Count();

                    label2Diretorios.Text = directoryCount.ToString(); 
                    label2Ficheiros.Text = fCount.ToString();
                }
                catch
                {
                    _FormInicio.EscreverNaConsola("Erro ao contar ficheiros!");
                }                
            }
        }        

    }
}
