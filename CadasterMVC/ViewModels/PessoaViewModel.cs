﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadasterMVC.Models
{
    public class PessoaViewModel
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public string Empresa { get; set; }
        public string Contato { get; set; }
    }
}
