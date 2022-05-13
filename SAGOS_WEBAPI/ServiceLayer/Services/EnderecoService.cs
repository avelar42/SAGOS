using DomainLayer.Models;
using RepositoryLayer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class EnderecoService : IEnderecoService
    {
        private IRepository<Endereco> _repository;

        public EnderecoService(IRepository<Endereco> repository)
        {
            _repository = repository;
        }

        public IEnumerable<Endereco> GetAllEnderecos()
        {
            return _repository.GetAll();
        }

        public Endereco GetEndereco(Guid id)
        {
            return _repository.Get(id);          
        }

        public void InsertEndereco(Endereco endereco)
        {
            _repository.Insert(endereco);
        }

        public void RemoveEndereco(Guid id)
        {
            var res = _repository.Get(id);
            if(res is not null)
            {
                _repository.Remove(res);
            }
        }

        public void UpdateEndereco(Endereco endereco)
        {
            _repository.Update(endereco);
        }
    }
}
