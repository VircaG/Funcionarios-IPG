﻿// <auto-generated />
// <auto-generated />
using IPG_Funcionarios.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace IPG_Funcionarios.Migrations
{
    [DbContext(typeof(IPGFuncionariosDbContext))]
    [Migration("20200104140158_feria")]
    partial class ferias
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("IPG_Funcionarios.Models.Feria", b =>
            {
                b.Property<int>("FeriaID")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<DateTime>("DataFim")
                    .HasColumnType("datetime2");

                b.Property<DateTime>("DataInicio")
                    .HasColumnType("datetime2");

                b.Property<int>("QuemID")
                    .HasColumnType("int");

                b.Property<string>("TipoFeria")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.HasKey("FeriaID");

                b.ToTable("Feria");
            });

#pragma warning restore 612, 618
        }
    }
}
