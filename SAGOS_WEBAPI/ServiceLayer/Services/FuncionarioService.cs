using DomainLayer.Models;
using RepositoryLayer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class FuncionarioService : IFuncionarioService
    {

        private IRepository<Funcionario> _repository;

        public FuncionarioService(IRepository<Funcionario> repository)
        {
            _repository = repository;
        }
        public IEnumerable<Funcionario> GetAllFuncionarios()
        {
            return _repository.GetAll();
        }

        public Funcionario getFuncionario(Guid id)
        {
            return _repository.Get(id);
        }

        public void InsertFuncionario(Funcionario funcionario)
        {
            _repository.Insert(funcionario);
        }

        public void RemoveFuncionario(Guid id)
        {
            var func = _repository.Get(id);
            if(func is not null)
            {
                _repository.Remove(func);
            }
        }

        public void UpdateFuncionario(Funcionario funcionario)
        {
            _repository.Update(funcionario);
        }
    }
}
