using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PromosV1.Models
{
    public class PromocaoViewModel : PadraoViewModel
    {
        public string Nome { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public int Carimbos { get; set; }
        public int IdMestre { get; set; }
    }
}
