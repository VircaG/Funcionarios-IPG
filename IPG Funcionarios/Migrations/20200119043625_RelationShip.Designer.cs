﻿// <auto-generated />
using System;
using IPG_Funcionarios.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace IPG_Funcionarios.Migrations
{
    [DbContext(typeof(IPGFuncionariosDbContext))]
    [Migration("20200119043625_RelationShip")]
    partial class RelationShip
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("IPG_Funcionarios.Models.Cargo", b =>
                {
                    b.Property<int>("CargoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CargoChefe")
                        .HasColumnType("int");

                    b.Property<string>("NomeCargo")
                        .IsRequired()
                        .HasColumnType("nvarchar(220)")
                        .HasMaxLength(220);

                    b.HasKey("CargoID");

                    b.HasIndex("CargoChefe");

                    b.ToTable("Cargo");
                });

            modelBuilder.Entity("IPG_Funcionarios.Models.Departamento", b =>
                {
                    b.Property<int>("DepartamentoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EscolaForeignKey")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DepartamentoId");

                    b.HasIndex("EscolaForeignKey");

                    b.ToTable("Departamento");
                });

            modelBuilder.Entity("IPG_Funcionarios.Models.Escola", b =>
                {
                    b.Property<int>("EscolaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("Localizacao")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(180)")
                        .HasMaxLength(180);

                    b.HasKey("EscolaID");

                    b.ToTable("Escola");
                });

            modelBuilder.Entity("IPG_Funcionarios.Models.Ferias", b =>
                {
                    b.Property<int>("FeriasID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataFim")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataInicio")
                        .HasColumnType("datetime2");

                    b.Property<int>("FuncionarioForeignKey")
                        .HasColumnType("int");

                    b.Property<int>("ProfessorForeignKey")
                        .HasColumnType("int");

                    b.Property<int>("QuemID")
                        .HasColumnType("int");

                    b.Property<string>("TipoFerias")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FeriasID");

                    b.HasIndex("FuncionarioForeignKey");

                    b.HasIndex("ProfessorForeignKey");

                    b.ToTable("Ferias");
                });

            modelBuilder.Entity("IPG_Funcionarios.Models.Funcionario", b =>
                {
                    b.Property<int>("FuncionarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataNascionento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Genero")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Morada")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FuncionarioId");

                    b.ToTable("Funcionario");
                });

            modelBuilder.Entity("IPG_Funcionarios.Models.FuncionarioTarefaCargo", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CargoForeignKey")
                        .HasColumnType("int");

                    b.Property<int>("FuncionarioForeignKey")
                        .HasColumnType("int");

                    b.Property<int>("TarefaForeignKey")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("CargoForeignKey");

                    b.HasIndex("FuncionarioForeignKey");

                    b.HasIndex("TarefaForeignKey");

                    b.ToTable("FuncionarioTarefaCargo");
                });

            modelBuilder.Entity("IPG_Funcionarios.Models.Professor", b =>
                {
                    b.Property<int>("ProfessorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Contacto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DepartamentoForeignKey")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gabinete")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.HasKey("ProfessorId");

                    b.HasIndex("DepartamentoForeignKey");

                    b.ToTable("Professor");
                });

            modelBuilder.Entity("IPG_Funcionarios.Models.ProfessorTarefaCargo", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CargoForeignKey")
                        .HasColumnType("int");

                    b.Property<int>("ProfessorForeignKey")
                        .HasColumnType("int");

                    b.Property<int>("TarefaForeignKey")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("CargoForeignKey");

                    b.HasIndex("ProfessorForeignKey");

                    b.HasIndex("TarefaForeignKey");

                    b.ToTable("ProfessorTarefaCargo");
                });

            modelBuilder.Entity("IPG_Funcionarios.Models.Servico", b =>
                {
                    b.Property<int>("ServicoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EscolaForeignKey")
                        .HasColumnType("int");

                    b.Property<int>("FuncionarioForeignKey")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.HasKey("ServicoId");

                    b.HasIndex("EscolaForeignKey");

                    b.HasIndex("FuncionarioForeignKey");

                    b.ToTable("Servico");
                });

            modelBuilder.Entity("IPG_Funcionarios.Models.Tarefa", b =>
                {
                    b.Property<int>("TarefaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<int>("FuncionarioForeignKey")
                        .HasColumnType("int");

                    b.Property<int?>("FuncionariosFuncionarioId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.Property<int>("ProfessorForeignKey")
                        .HasColumnType("int");

                    b.Property<int?>("ProfessoresProfessorId")
                        .HasColumnType("int");

                    b.HasKey("TarefaID");

                    b.HasIndex("FuncionariosFuncionarioId");

                    b.HasIndex("ProfessoresProfessorId");

                    b.ToTable("Tarefa");
                });

            modelBuilder.Entity("IPG_Funcionarios.Models.Cargo", b =>
                {
                    b.HasOne("IPG_Funcionarios.Models.Cargo", "Chefe")
                        .WithMany()
                        .HasForeignKey("CargoChefe");
                });

            modelBuilder.Entity("IPG_Funcionarios.Models.Departamento", b =>
                {
                    b.HasOne("IPG_Funcionarios.Models.Escola", "Escola")
                        .WithMany("Departamentos")
                        .HasForeignKey("EscolaForeignKey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("IPG_Funcionarios.Models.Ferias", b =>
                {
                    b.HasOne("IPG_Funcionarios.Models.Funcionario", "Funcionario")
                        .WithMany("Ferias")
                        .HasForeignKey("FuncionarioForeignKey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IPG_Funcionarios.Models.Professor", "Professor")
                        .WithMany("Ferias")
                        .HasForeignKey("ProfessorForeignKey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("IPG_Funcionarios.Models.FuncionarioTarefaCargo", b =>
                {
                    b.HasOne("IPG_Funcionarios.Models.Cargo", "Cargo")
                        .WithMany("FuncionarioTarefaCargos")
                        .HasForeignKey("CargoForeignKey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IPG_Funcionarios.Models.Funcionario", "Funcionario")
                        .WithMany("FuncionarioTarefaCargos")
                        .HasForeignKey("FuncionarioForeignKey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IPG_Funcionarios.Models.Tarefa", "Tarefa")
                        .WithMany("FuncionarioTarefaCargos")
                        .HasForeignKey("TarefaForeignKey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("IPG_Funcionarios.Models.Professor", b =>
                {
                    b.HasOne("IPG_Funcionarios.Models.Departamento", "Departamento")
                        .WithMany("Professores")
                        .HasForeignKey("DepartamentoForeignKey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("IPG_Funcionarios.Models.ProfessorTarefaCargo", b =>
                {
                    b.HasOne("IPG_Funcionarios.Models.Cargo", "Cargo")
                        .WithMany("ProfessorTarefaCargos")
                        .HasForeignKey("CargoForeignKey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IPG_Funcionarios.Models.Professor", "Professor")
                        .WithMany("ProfessorTarefaCargos")
                        .HasForeignKey("ProfessorForeignKey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IPG_Funcionarios.Models.Tarefa", "Tarefa")
                        .WithMany("ProfessorTarefaCargos")
                        .HasForeignKey("TarefaForeignKey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("IPG_Funcionarios.Models.Servico", b =>
                {
                    b.HasOne("IPG_Funcionarios.Models.Escola", "Escola")
                        .WithMany("Servicos")
                        .HasForeignKey("EscolaForeignKey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IPG_Funcionarios.Models.Funcionario", "Funcionario")
                        .WithMany("Servicos")
                        .HasForeignKey("FuncionarioForeignKey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("IPG_Funcionarios.Models.Tarefa", b =>
                {
                    b.HasOne("IPG_Funcionarios.Models.Funcionario", "Funcionarios")
                        .WithMany()
                        .HasForeignKey("FuncionariosFuncionarioId");

                    b.HasOne("IPG_Funcionarios.Models.Professor", "Professores")
                        .WithMany()
                        .HasForeignKey("ProfessoresProfessorId");
                });
#pragma warning restore 612, 618
        }
    }
}
