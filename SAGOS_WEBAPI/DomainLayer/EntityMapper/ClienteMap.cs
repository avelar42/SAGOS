using DomainLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.EntityMapper
{
    public class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasKey(x => x.Id)
                .HasName("PK_CLienteId");
            builder.Property(x => x.Id)
                .HasColumnName("Id")
                .HasColumnType("uniqueidentifier");
            builder.Property(x => x.NomeCliente)
               .HasColumnName("Nome")
               .HasColumnType("Varchar(255)")
               .IsRequired();
            builder.Property(x => x.Telefone)
               .HasColumnName("Telefone")
               .HasColumnType("Varchar(64)")
               .IsRequired();
            builder.Property(x => x.CPF)
              .HasColumnName("CPF")
              .HasColumnType("int")
              .IsRequired();
            builder.Property(x => x.IsActive)
                .HasColumnType("Active")
                .HasColumnType("bit");
            builder.HasMany(x => x.Ativos).WithOne(c => c.Cliente).HasForeignKey(c => c.ClienteId);
            builder.HasMany(x => x.Enderecos).WithOne(c => c.Cliente).HasForeignKey(c => c.ClienteId);

        }
    }
}
