using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RascalApp.Models
{
    public class Galeria
    {
        public int ID { get; set; }
        public int Identificador { get; set; }
        public int Tipo { get; set; }
        public string Designacao { get; set; }
        public int Visualizacoes { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
