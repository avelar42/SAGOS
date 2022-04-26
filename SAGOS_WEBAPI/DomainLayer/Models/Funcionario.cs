using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class Funcionario : BaseEntity
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
    }
}
