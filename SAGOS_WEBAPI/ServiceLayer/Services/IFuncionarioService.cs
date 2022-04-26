using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public interface IFuncionarioService
    {
        IEnumerable<Funcionario> GetAllFuncionarios();
        Funcionario getFuncionario(Guid id);
        void InsertFuncionario(Funcionario funcionario);
        void UpdateFuncionario(Funcionario funcionario);
        void RemoveFuncionario(Guid id);
    }
}
