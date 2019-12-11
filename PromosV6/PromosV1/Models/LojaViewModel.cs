﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PromosV1.Models
{
    public class LojaViewModel : PadraoViewModel
    {
        public string Cnpj { get; set; }
        public string Nome { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public int IdEmpresa { get; set; }
    }
}
