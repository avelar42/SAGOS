using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public interface IClienteService
    {
        IEnumerable<Cliente> GetAllClientes();
        Cliente GetCliente(Guid id);
        void InsertClientes(Cliente cliente);
        void UpdateClientes(Cliente cliente);
        void RemoveClientes(Guid id);
    }
}

