using Microsoft.EntityFrameworkCore;
using Model.Cliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcess.Config
{
    public class ContextBase : DbContext
    {
        public ContextBase(DbContextOptions<ContextBase> options) : base(options)
        {
            
        }

        public DbSet<ClienteViewModel> Clientes { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<ClienteViewModel>().Property(p => p.Nome).HasMaxLength(255);
            modelBuilder.Entity<ClienteViewModel>().Property(p => p.Sobrenome).HasMaxLength(255);
            modelBuilder.Entity<ClienteViewModel>().Property(p => p.Telefone);
        }

        private string GetStringConnectionConfig()
        {
            string strCon = "Data Source=localhost,1433;Initial Catalog=API_CORE_AULA;Integrated Security=False;User ID=SA;Password=Daniel!2021;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";
            return strCon;
        }
    }
}
