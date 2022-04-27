using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class Cliente : BaseEntity
    {
        public string NomeCliente { get; set; }
        public string Telefone { get; set; }
        public int CPF { get; set; }
        public ICollection<Ativo> Ativos { get; set; }
        public ICollection<Endereco> Enderecos { get; set; }


    }
}
