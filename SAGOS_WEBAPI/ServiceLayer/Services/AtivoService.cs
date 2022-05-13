using DomainLayer.Models;
using RepositoryLayer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class AtivoService : IAtivoService
    {
        private IRepository<Ativo> _repository;

        public AtivoService(IRepository<Ativo> repository)
        {
            _repository = repository;
        }
        public IEnumerable<Ativo> GetAllAtivos()
        {
            return _repository.GetAll();
        }

        public Ativo GetAtivo(Guid id)
        {
            return _repository.Get(id);
        }

        public void InsertAtivo(Ativo ativo)
        {
            _repository.Insert(ativo);
        }

        public void RemoveAtivo(Guid id)
        {
            var ativo = _repository.Get(id);
            if(ativo is not null)
            {
                _repository.Remove(ativo);
            }
        }

        public void UpdateAtivo(Ativo ativo)
        {
            _repository.Update(ativo);
        }
    }
}
