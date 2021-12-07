using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.models
{
    public class Funcionario
    {
         public Funcionario() => CriadoEm = DateTime.Now;
        public int FuncionarioId { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public DateTime CriadoEm { get; set; }
    }
}