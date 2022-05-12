using DomainLayer.Models;
using RepositoryLayer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class ClienteService : IClienteService
    {
        private IRepository<Cliente> _repository;
        public ClienteService(IRepository<Cliente> repository)
        {
            _repository = repository;
        }
        public IEnumerable<Cliente> GetAllClientes()
        {
            return _repository.GetAll();
        }

        public Cliente GetCliente(Guid id)
        {
            return _repository.Get(id);
        }

        public void InsertClientes(Cliente cliente)
        {
            _repository.Insert(cliente);
        }

        public void RemoveClientes(Guid id)
        {
            var cliente = _repository.Get(id);
            if(cliente is not null)
            {
                _repository.Remove(cliente);
            }

        }

        public void UpdateClientes(Cliente cliente)
        {

            _repository.Update(cliente);
        }
    }
}
