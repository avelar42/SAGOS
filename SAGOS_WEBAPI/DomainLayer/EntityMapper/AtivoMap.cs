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
    public class AtivoMap : IEntityTypeConfiguration<Ativo>
    {
        public void Configure(EntityTypeBuilder<Ativo> builder)
        {
            builder.HasKey(x => x.Id)
                .HasName("PK_AtivoId");
            builder.Property(x => x.Id)
                .HasColumnName("Id")
                .HasColumnType("uniqueidentifier");
            builder.Property(x => x.NomeAtivo)
               .HasColumnName("NomeAtivo")
               .HasColumnType("Varchar(255)")
               .IsRequired();
            builder.Property(x => x.Identificador)
               .HasColumnName("Identificador")
               .HasColumnType("Varchar(255)")
               .IsRequired();
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
