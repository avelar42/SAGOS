using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public interface IAtivoService
    {
        IEnumerable<Ativo> GetAllAtivos();
        Ativo GetAtivo(Guid id);
        void InsertAtivo(Ativo ativo);
        void UpdateAtivo(Ativo ativo);
        void RemoveAtivo(Guid id);
    }
}
