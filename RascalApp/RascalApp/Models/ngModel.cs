using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RascalApp.Models
{
    public class ngModel
    {
        public ngModel()
        {
            caminhoFotos = new List<string>();
        }

        public string NomeGal { get; set; }
        public List<String> caminhoFotos { get; set; }
    }
}
