﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RascalApp.Models
{
    public class Galeria
    {
        public int ID { get; set; }
        public int IdModelo { get; set; }
        public int IdErmo { get; set; }
        public string Designacao { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
