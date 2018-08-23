using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RascalApp.Models
{
    public class Foto
    {
        public int ID { get; set; }
        public int IdGaleria { get; set; }
        public string CaminhoFoto { get; set; }
        public int Visualizacoes { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
