// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RepositoryLayer;

namespace RepositoryLayer.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220424034035_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DomainLayer.Models.Funcionario", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("Varchar(255)")
                        .HasColumnName("Id");

                    b.Property<DateTime>("EntryDate")
                        .HasColumnType("datetime")
                        .HasColumnName("EntryDate");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit")
                        .HasColumnName("IsActive");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("Varchar(255)")
                        .HasColumnName("Nome");

                    b.Property<string>("Telefone")
                        .HasColumnType("Varchar(255)")
                        .HasColumnName("Telefone");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime")
                        .HasColumnName("UpdateDate");

                    b.HasKey("Id")
                        .HasName("pk_funcId");

                    b.ToTable("Funcionario");
                });
#pragma warning restore 612, 618
        }
    }
}
