using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public interface IEnderecoService
    {
        IEnumerable<Endereco> GetAllEnderecos();
        Endereco GetEndereco(Guid id);
        void InsertEndereco(Endereco endereco);
        void UpdateEndereco(Endereco endereco);
        void RemoveEndereco(Guid id);
    }
}
