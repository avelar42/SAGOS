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
    public class EnderecoMap : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.HasKey(x => x.Id)
                .HasName("Pk_EnderecoId");
            builder.Property(x => x.Id)
                .HasColumnName("Id")
                .HasColumnType("uniqueidentifier");
            builder.Property(x => x.Rua)
               .HasColumnName("Rua")
               .HasColumnType("Varchar(255)");
            builder.Property(x => x.Numero)
               .HasColumnName("Numero")
               .HasColumnType("int");
            builder.Property(x => x.Bairro)
               .HasColumnName("Bairro")
               .HasColumnType("Varchar(255)");
            builder.Property(x => x.Complemento)
               .HasColumnName("Complemento")
               .HasColumnType("Varchar(255)");
            builder.Property(x => x.Cidade)
               .HasColumnName("Cidade")
               .HasColumnType("Varchar(255)");
            builder.Property(x => x.EntryDate)
               .HasColumnName("EntryDate")
               .HasColumnType("datetime")
               .IsRequired();
            builder.Property(x => x.UpdateDate)
                .HasColumnName("UpdateDate")
                .HasColumnType("datetime");
            builder.Property(x => x.IsActive)
                .HasColumnType("Active")
                .HasColumnType("bit");
        }
    }
}
