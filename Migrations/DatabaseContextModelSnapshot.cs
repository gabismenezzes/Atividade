using System;
using WebApplication.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
namespace WebApplication.Migrations
{
    namespace WebApplication.Migrations
    {
        [DbContext(typeof(DataBaseContext))]
        partial class DatabaseContextModelSnapshot : ModelSnapshot
        {
            protected override void BuildModel(ModelBuilder modelBuilder)
            {
#pragma warning disable 612, 618
                modelBuilder
                    .HasAnnotation("ProductVersion", "3.1.13")
                    .HasAnnotation("Relational:MaxIdentifierLength", 64);

                modelBuilder.Entity("Buffet.Models.Buffet.Cliente.ClienteEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DataDeNascimento")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("Idade")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Sobrenome")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });
#pragma warning restore 612, 618
            }
        }
    }

    }