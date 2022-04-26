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
    public class FuncionarioMap : IEntityTypeConfiguration<Funcionario>
    {
        public void Configure(EntityTypeBuilder<Funcionario> builder)
        {
            builder.HasKey(x => x.Id)
                .HasName("pk_funcId");
            builder.Property(x => x.Id)
                .HasColumnName("Id")
                .HasColumnType("Varchar(255)");
            builder.Property(x => x.Nome)
                .HasColumnName("Nome")
                .HasColumnType("Varchar(255)")
                .IsRequired();
            builder.Property(x => x.Telefone)
                .HasColumnName("Telefone")
                .HasColumnType("Varchar(255)");
            builder.Property(x => x.EntryDate)
                .HasColumnName("EntryDate")
                .HasColumnType("datetime");
            builder.Property(x => x.UpdateDate)
                .HasColumnName("UpdateDate")
                .HasColumnType("datetime");
            builder.Property(x => x.IsActive)
                .HasColumnName("IsActive")
                .HasColumnType("bit");


        }
    }
}
