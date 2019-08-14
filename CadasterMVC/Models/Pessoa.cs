using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadasterMVC.Models
{
    public class Pessoa
    {
        public long Id { get; set; }
        public int MyProperty { get; set; }
        public string Nome { get; set; }
        public string Empresa { get; set; }
        public string Contato { get; set; }
        public string Sexo { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime UltimaAtualizacao { get; set; }
    }
}
