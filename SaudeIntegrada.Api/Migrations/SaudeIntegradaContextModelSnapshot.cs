﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SaudeIntegrada.Repository.Context;

#nullable disable

namespace SaudeIntegrada.Api.Migrations
{
    [DbContext(typeof(SaudeIntegradaContext))]
    partial class SaudeIntegradaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SaudeIntegrada.Domain.AvaliacaoFicha", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

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

                    b.HasKey("Id");

                    b.HasIndex("PessoaId");

                    b.ToTable("AvaliacaoFicha", (string)null);
                });

            modelBuilder.Entity("SaudeIntegrada.Domain.Conta", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Conta", (string)null);
                });

            modelBuilder.Entity("SaudeIntegrada.Domain.ExercicioBase", b =>
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

            modelBuilder.Entity("SaudeIntegrada.Domain.ExercicioFicha", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ExercicioBaseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("FichaId")
                        .HasColumnType("uniqueidentifier");

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

            modelBuilder.Entity("SaudeIntegrada.Domain.Ficha", b =>
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

            modelBuilder.Entity("SaudeIntegrada.Domain.Pessoa", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Pessoa", (string)null);
                });

            modelBuilder.Entity("SaudeIntegrada.Domain.AvaliacaoFicha", b =>
                {
                    b.HasOne("SaudeIntegrada.Domain.Pessoa", "Pessoa")
                        .WithMany("AvaliacaoFichas")
                        .HasForeignKey("PessoaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pessoa");
                });

            modelBuilder.Entity("SaudeIntegrada.Domain.Conta", b =>
                {
                    b.HasOne("SaudeIntegrada.Domain.Pessoa", "Pessoa")
                        .WithOne("Conta")
                        .HasForeignKey("SaudeIntegrada.Domain.Conta", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pessoa");
                });

            modelBuilder.Entity("SaudeIntegrada.Domain.ExercicioFicha", b =>
                {
                    b.HasOne("SaudeIntegrada.Domain.ExercicioBase", "ExercicioBase")
                        .WithMany()
                        .HasForeignKey("ExercicioBaseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SaudeIntegrada.Domain.Ficha", null)
                        .WithMany("ExerciciosFicha")
                        .HasForeignKey("FichaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("ExercicioBase");
                });

            modelBuilder.Entity("SaudeIntegrada.Domain.Ficha", b =>
                {
                    b.HasOne("SaudeIntegrada.Domain.AvaliacaoFicha", null)
                        .WithMany("Fichas")
                        .HasForeignKey("AvaliacaoFichaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SaudeIntegrada.Domain.AvaliacaoFicha", b =>
                {
                    b.Navigation("Fichas");
                });

            modelBuilder.Entity("SaudeIntegrada.Domain.Ficha", b =>
                {
                    b.Navigation("ExerciciosFicha");
                });

            modelBuilder.Entity("SaudeIntegrada.Domain.Pessoa", b =>
                {
                    b.Navigation("AvaliacaoFichas");

                    b.Navigation("Conta")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
