﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SaudeIntegrada.Repository.Context;

#nullable disable

namespace SaudeIntegrada.Api.Migrations
{
    [DbContext(typeof(SaudeIntegradaContext))]
    [Migration("20240412003847_mssql.onprem_migration_590")]
    partial class mssqlonpremmigration590
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SaudeIntegrada.Domain.Domains.AvaliacaoFicha", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataProximoTesteCarga")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataTesteCarga")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descanso")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Duracao")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Metodo")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Nivel")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Objetivo")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Observacoes")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<Guid>("PessoaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("VelocidadeExecucao")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("ZonaQueima")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.HasIndex("PessoaId");

                    b.ToTable("AvaliacaoFicha", (string)null);
                });

            modelBuilder.Entity("SaudeIntegrada.Domain.Domains.Conta", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Apelido")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Conta", (string)null);
                });

            modelBuilder.Entity("SaudeIntegrada.Domain.Domains.ExercicioBase", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("ExercicioBase", (string)null);
                });

            modelBuilder.Entity("SaudeIntegrada.Domain.Domains.ExercicioFicha", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Carga")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<Guid>("ExercicioBaseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("FichaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Observacoes")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Repeticoes")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Sets")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.HasIndex("ExercicioBaseId");

                    b.HasIndex("FichaId");

                    b.ToTable("ExercicioFicha", (string)null);
                });

            modelBuilder.Entity("SaudeIntegrada.Domain.Domains.Ficha", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("AvaliacaoFichaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.HasIndex("AvaliacaoFichaId");

                    b.ToTable("Ficha", (string)null);
                });

            modelBuilder.Entity("SaudeIntegrada.Domain.Domains.Pessoa", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ContaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Sexo")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.HasIndex("ContaId")
                        .IsUnique();

                    b.ToTable("Pessoa", (string)null);
                });

            modelBuilder.Entity("SaudeIntegrada.Domain.Domains.AvaliacaoFicha", b =>
                {
                    b.HasOne("SaudeIntegrada.Domain.Domains.Pessoa", "Pessoa")
                        .WithMany("AvaliacaoFichas")
                        .HasForeignKey("PessoaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pessoa");
                });

            modelBuilder.Entity("SaudeIntegrada.Domain.Domains.ExercicioFicha", b =>
                {
                    b.HasOne("SaudeIntegrada.Domain.Domains.ExercicioBase", "ExercicioBase")
                        .WithMany()
                        .HasForeignKey("ExercicioBaseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SaudeIntegrada.Domain.Domains.Ficha", null)
                        .WithMany("ExerciciosFicha")
                        .HasForeignKey("FichaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("ExercicioBase");
                });

            modelBuilder.Entity("SaudeIntegrada.Domain.Domains.Ficha", b =>
                {
                    b.HasOne("SaudeIntegrada.Domain.Domains.AvaliacaoFicha", null)
                        .WithMany("Fichas")
                        .HasForeignKey("AvaliacaoFichaId");
                });

            modelBuilder.Entity("SaudeIntegrada.Domain.Domains.Pessoa", b =>
                {
                    b.HasOne("SaudeIntegrada.Domain.Domains.Conta", "Conta")
                        .WithOne("Pessoa")
                        .HasForeignKey("SaudeIntegrada.Domain.Domains.Pessoa", "ContaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Conta");
                });

            modelBuilder.Entity("SaudeIntegrada.Domain.Domains.AvaliacaoFicha", b =>
                {
                    b.Navigation("Fichas");
                });

            modelBuilder.Entity("SaudeIntegrada.Domain.Domains.Conta", b =>
                {
                    b.Navigation("Pessoa")
                        .IsRequired();
                });

            modelBuilder.Entity("SaudeIntegrada.Domain.Domains.Ficha", b =>
                {
                    b.Navigation("ExerciciosFicha");
                });

            modelBuilder.Entity("SaudeIntegrada.Domain.Domains.Pessoa", b =>
                {
                    b.Navigation("AvaliacaoFichas");
                });
#pragma warning restore 612, 618
        }
    }
}
