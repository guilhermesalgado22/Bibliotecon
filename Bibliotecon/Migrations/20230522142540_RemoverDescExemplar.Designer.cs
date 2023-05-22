﻿// <auto-generated />
using System;
using Bibliotecon.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Bibliotecon.Migrations
{
    [DbContext(typeof(DemoDbContext))]
    [Migration("20230522142540_RemoverDescExemplar")]
    partial class RemoverDescExemplar
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseCollation("utf8mb4_0900_ai_ci")
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.HasCharSet(modelBuilder, "utf8mb4");

            modelBuilder.Entity("Bibliotecon.Models.Cidade", b =>
                {
                    b.Property<int>("CodCidade")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("cod_cidade");

                    b.Property<int?>("CodEstado")
                        .HasColumnType("int")
                        .HasColumnName("cod_estado");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("nome");

                    b.HasKey("CodCidade")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "CodEstado" }, "cod_estado");

                    b.ToTable("tb_cidade", (string)null);
                });

            modelBuilder.Entity("Bibliotecon.Models.Devolucao", b =>
                {
                    b.Property<int>("CodDevolucao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("cod_devolucao");

                    b.Property<int>("CodEmprestimo")
                        .HasColumnType("int")
                        .HasColumnName("cod_emprestimo");

                    b.Property<int>("CodExemplar")
                        .HasColumnType("int")
                        .HasColumnName("cod_exemplar");

                    b.Property<int>("CodFuncionario")
                        .HasColumnType("int")
                        .HasColumnName("cod_funcionario");

                    b.Property<DateOnly?>("DataDevolucao")
                        .HasColumnType("date")
                        .HasColumnName("data_devolucao");

                    b.Property<int>("Multa")
                        .HasColumnType("int")
                        .HasColumnName("multa");

                    b.Property<bool>("Status")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("status");

                    b.HasKey("CodDevolucao")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "CodEmprestimo" }, "cod_emprestimo");

                    b.HasIndex(new[] { "CodExemplar" }, "cod_exemplar");

                    b.HasIndex(new[] { "CodFuncionario" }, "cod_funcionario");

                    b.ToTable("tb_devolucao", (string)null);
                });

            modelBuilder.Entity("Bibliotecon.Models.Endereco", b =>
                {
                    b.Property<int>("CodEndereco")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("cod_endereco");

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("bairro");

                    b.Property<int>("CodCidade")
                        .HasColumnType("int")
                        .HasColumnName("cod_cidade");

                    b.Property<string>("DescEndereco")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("desc_endereco");

                    b.Property<int>("Numero")
                        .HasColumnType("int")
                        .HasColumnName("numero");

                    b.HasKey("CodEndereco")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "CodCidade" }, "cod_cidade");

                    b.ToTable("tb_endereco", (string)null);
                });

            modelBuilder.Entity("Bibliotecon.Models.Estado", b =>
                {
                    b.Property<int>("CodEstado")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("cod_estado");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("nome");

                    b.Property<string>("Sigla")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("varchar(2)")
                        .HasColumnName("sigla");

                    b.HasKey("CodEstado")
                        .HasName("PRIMARY");

                    b.ToTable("tb_estado", (string)null);
                });

            modelBuilder.Entity("Bibliotecon.Models.Exemplar", b =>
                {
                    b.Property<int>("CodExemplar")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("cod_exemplar");

                    b.Property<int>("CodFuncionario")
                        .HasColumnType("int")
                        .HasColumnName("cod_funcionario");

                    b.Property<int>("CodLivro")
                        .HasColumnType("int")
                        .HasColumnName("cod_livro");

                    b.Property<bool>("Status")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("status");

                    b.HasKey("CodExemplar")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "CodFuncionario" }, "cod_funcionario")
                        .HasDatabaseName("cod_funcionario1");

                    b.HasIndex(new[] { "CodLivro" }, "cod_livro");

                    b.ToTable("tb_exemplar", (string)null);
                });

            modelBuilder.Entity("Bibliotecon.Models.ExemplarEmprestimo", b =>
                {
                    b.Property<int>("CodEmprestimo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("cod_emprestimo");

                    b.Property<int>("CodExemplar")
                        .HasColumnType("int")
                        .HasColumnName("cod_exemplar");

                    b.Property<int>("CodFuncionario")
                        .HasColumnType("int")
                        .HasColumnName("cod_funcionario");

                    b.Property<int>("CodLeitor")
                        .HasColumnType("int")
                        .HasColumnName("cod_leitor");

                    b.Property<int>("CodReserva")
                        .HasColumnType("int");

                    b.Property<DateOnly?>("DataDevolucao")
                        .HasColumnType("date")
                        .HasColumnName("data_devolucao");

                    b.Property<DateOnly?>("DataEmprestimo")
                        .HasColumnType("date")
                        .HasColumnName("data_emprestimo");

                    b.Property<string>("DescExemplar")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("desc_exemplar");

                    b.Property<int>("ReservaCodReserva")
                        .HasColumnType("int");

                    b.HasKey("CodEmprestimo")
                        .HasName("PRIMARY");

                    b.HasIndex("ReservaCodReserva");

                    b.HasIndex(new[] { "CodExemplar" }, "cod_exemplar")
                        .HasDatabaseName("cod_exemplar1");

                    b.HasIndex(new[] { "CodFuncionario" }, "cod_funcionario")
                        .HasDatabaseName("cod_funcionario2");

                    b.HasIndex(new[] { "CodLeitor" }, "cod_leitor");

                    b.ToTable("tb_exemplar_emprestimo", (string)null);
                });

            modelBuilder.Entity("Bibliotecon.Models.Funcionario", b =>
                {
                    b.Property<int>("CodCadastro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("cod_cadastro");

                    b.Property<int>("CodCidade")
                        .HasColumnType("int")
                        .HasColumnName("cod_cidade");

                    b.Property<int>("CodEndereco")
                        .HasColumnType("int")
                        .HasColumnName("cod_endereco");

                    b.Property<int>("CodEstado")
                        .HasColumnType("int")
                        .HasColumnName("cod_estado");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasMaxLength(14)
                        .HasColumnType("varchar(14)")
                        .HasColumnName("cpf");

                    b.Property<DateOnly>("DataNascimento")
                        .HasColumnType("date")
                        .HasColumnName("data_nascimento");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("nome");

                    b.Property<string>("Rg")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("varchar(13)")
                        .HasColumnName("rg");

                    b.Property<decimal>("Salario")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)")
                        .HasColumnName("salario");

                    b.Property<string>("Sexo")
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnType("varchar(1)")
                        .HasColumnName("sexo");

                    b.Property<bool>("Status")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("status");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("varchar(13)")
                        .HasColumnName("telefone");

                    b.HasKey("CodCadastro")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "CodCidade" }, "cod_cidade")
                        .HasDatabaseName("cod_cidade1");

                    b.HasIndex(new[] { "CodEndereco" }, "cod_endereco");

                    b.HasIndex(new[] { "CodEstado" }, "cod_estado")
                        .HasDatabaseName("cod_estado1");

                    b.ToTable("tb_funcionario", (string)null);
                });

            modelBuilder.Entity("Bibliotecon.Models.Leitor", b =>
                {
                    b.Property<int>("CodLeitor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("cod_leitor");

                    b.Property<int>("CodCidade")
                        .HasColumnType("int")
                        .HasColumnName("cod_cidade");

                    b.Property<int>("CodEndereco")
                        .HasColumnType("int")
                        .HasColumnName("cod_endereco");

                    b.Property<int>("CodEstado")
                        .HasColumnType("int")
                        .HasColumnName("cod_estado");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasMaxLength(14)
                        .HasColumnType("varchar(14)")
                        .HasColumnName("cpf");

                    b.Property<DateOnly>("DataNascimento")
                        .HasColumnType("date")
                        .HasColumnName("data_nascimento");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("nome");

                    b.Property<int>("PrazoDevolucao")
                        .HasColumnType("int")
                        .HasColumnName("prazo_devolucao");

                    b.Property<string>("Rg")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("varchar(13)")
                        .HasColumnName("rg");

                    b.Property<string>("Sexo")
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnType("varchar(1)")
                        .HasColumnName("sexo");

                    b.Property<bool>("Status")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("status");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("varchar(13)")
                        .HasColumnName("telefone");

                    b.HasKey("CodLeitor")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "CodCidade" }, "cod_cidade")
                        .HasDatabaseName("cod_cidade2");

                    b.HasIndex(new[] { "CodEndereco" }, "cod_endereco")
                        .HasDatabaseName("cod_endereco1");

                    b.HasIndex(new[] { "CodEstado" }, "cod_estado")
                        .HasDatabaseName("cod_estado2");

                    b.ToTable("tb_leitor", (string)null);
                });

            modelBuilder.Entity("Bibliotecon.Models.Livro", b =>
                {
                    b.Property<int>("CodLivro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("cod_livro");

                    b.Property<int>("AnoPublicacao")
                        .HasColumnType("int")
                        .HasColumnName("ano_publicacao");

                    b.Property<string>("Autor")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("autor");

                    b.Property<string>("Categoria")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("categoria");

                    b.Property<string>("Editora")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("editora");

                    b.Property<bool>("Status")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("status");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("titulo");

                    b.HasKey("CodLivro")
                        .HasName("PRIMARY");

                    b.ToTable("tb_livro", (string)null);
                });

            modelBuilder.Entity("Bibliotecon.Models.Reserva", b =>
                {
                    b.Property<int>("CodReserva")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("cod_reserva");

                    b.Property<int>("CodExemplar")
                        .HasColumnType("int")
                        .HasColumnName("cod_exemplar");

                    b.Property<int>("CodFuncionario")
                        .HasColumnType("int")
                        .HasColumnName("cod_funcionario");

                    b.Property<int>("CodLeitor")
                        .HasColumnType("int")
                        .HasColumnName("cod_leitor");

                    b.Property<DateOnly>("DataDevolucao")
                        .HasColumnType("date")
                        .HasColumnName("data_devolucao");

                    b.Property<DateOnly>("DataReserva")
                        .HasColumnType("date")
                        .HasColumnName("data_reserva");

                    b.HasKey("CodReserva")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "CodExemplar" }, "cod_exemplar")
                        .HasDatabaseName("cod_exemplar2");

                    b.HasIndex(new[] { "CodFuncionario" }, "cod_funcionario")
                        .HasDatabaseName("cod_funcionario3");

                    b.HasIndex(new[] { "CodLeitor" }, "cod_leitor")
                        .HasDatabaseName("cod_leitor1");

                    b.ToTable("tb_reserva", (string)null);
                });

            modelBuilder.Entity("Bibliotecon.Models.Cidade", b =>
                {
                    b.HasOne("Bibliotecon.Models.Estado", "CodEstadoNavigation")
                        .WithMany("TbCidades")
                        .HasForeignKey("CodEstado")
                        .HasConstraintName("tb_cidade_ibfk_1");

                    b.Navigation("CodEstadoNavigation");
                });

            modelBuilder.Entity("Bibliotecon.Models.Devolucao", b =>
                {
                    b.HasOne("Bibliotecon.Models.ExemplarEmprestimo", "CodEmprestimoNavigation")
                        .WithMany("TbDevolucaos")
                        .HasForeignKey("CodEmprestimo")
                        .IsRequired()
                        .HasConstraintName("tb_devolucao_ibfk_2");

                    b.HasOne("Bibliotecon.Models.Exemplar", "CodExemplarNavigation")
                        .WithMany("TbDevolucaos")
                        .HasForeignKey("CodExemplar")
                        .IsRequired()
                        .HasConstraintName("tb_devolucao_ibfk_3");

                    b.HasOne("Bibliotecon.Models.Funcionario", "CodFuncionarioNavigation")
                        .WithMany("TbDevolucaos")
                        .HasForeignKey("CodFuncionario")
                        .IsRequired()
                        .HasConstraintName("tb_devolucao_ibfk_1");

                    b.Navigation("CodEmprestimoNavigation");

                    b.Navigation("CodExemplarNavigation");

                    b.Navigation("CodFuncionarioNavigation");
                });

            modelBuilder.Entity("Bibliotecon.Models.Endereco", b =>
                {
                    b.HasOne("Bibliotecon.Models.Cidade", "CodCidadeNavigation")
                        .WithMany("TbEnderecos")
                        .HasForeignKey("CodCidade")
                        .IsRequired()
                        .HasConstraintName("tb_endereco_ibfk_1");

                    b.Navigation("CodCidadeNavigation");
                });

            modelBuilder.Entity("Bibliotecon.Models.Exemplar", b =>
                {
                    b.HasOne("Bibliotecon.Models.Funcionario", "CodFuncionarioNavigation")
                        .WithMany("TbExemplars")
                        .HasForeignKey("CodFuncionario")
                        .IsRequired()
                        .HasConstraintName("tb_exemplar_ibfk_2");

                    b.HasOne("Bibliotecon.Models.Livro", "CodLivroNavigation")
                        .WithMany("TbExemplars")
                        .HasForeignKey("CodLivro")
                        .IsRequired()
                        .HasConstraintName("tb_exemplar_ibfk_1");

                    b.Navigation("CodFuncionarioNavigation");

                    b.Navigation("CodLivroNavigation");
                });

            modelBuilder.Entity("Bibliotecon.Models.ExemplarEmprestimo", b =>
                {
                    b.HasOne("Bibliotecon.Models.Exemplar", "CodExemplarNavigation")
                        .WithMany("TbExemplarEmprestimos")
                        .HasForeignKey("CodExemplar")
                        .IsRequired()
                        .HasConstraintName("tb_exemplar_emprestimo_ibfk_2");

                    b.HasOne("Bibliotecon.Models.Funcionario", "CodFuncionarioNavigation")
                        .WithMany("TbExemplarEmprestimos")
                        .HasForeignKey("CodFuncionario")
                        .IsRequired()
                        .HasConstraintName("tb_exemplar_emprestimo_ibfk_1");

                    b.HasOne("Bibliotecon.Models.Leitor", "CodLeitorNavigation")
                        .WithMany("TbExemplarEmprestimos")
                        .HasForeignKey("CodLeitor")
                        .IsRequired()
                        .HasConstraintName("tb_exemplar_emprestimo_ibfk_3");

                    b.HasOne("Bibliotecon.Models.Reserva", "Reserva")
                        .WithMany()
                        .HasForeignKey("ReservaCodReserva")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CodExemplarNavigation");

                    b.Navigation("CodFuncionarioNavigation");

                    b.Navigation("CodLeitorNavigation");

                    b.Navigation("Reserva");
                });

            modelBuilder.Entity("Bibliotecon.Models.Funcionario", b =>
                {
                    b.HasOne("Bibliotecon.Models.Cidade", "CodCidadeNavigation")
                        .WithMany("TbFuncionarios")
                        .HasForeignKey("CodCidade")
                        .IsRequired()
                        .HasConstraintName("tb_funcionario_ibfk_3");

                    b.HasOne("Bibliotecon.Models.Endereco", "CodEnderecoNavigation")
                        .WithMany("TbFuncionarios")
                        .HasForeignKey("CodEndereco")
                        .IsRequired()
                        .HasConstraintName("tb_funcionario_ibfk_2");

                    b.HasOne("Bibliotecon.Models.Estado", "CodEstadoNavigation")
                        .WithMany("TbFuncionarios")
                        .HasForeignKey("CodEstado")
                        .IsRequired()
                        .HasConstraintName("tb_funcionario_ibfk_1");

                    b.Navigation("CodCidadeNavigation");

                    b.Navigation("CodEnderecoNavigation");

                    b.Navigation("CodEstadoNavigation");
                });

            modelBuilder.Entity("Bibliotecon.Models.Leitor", b =>
                {
                    b.HasOne("Bibliotecon.Models.Cidade", "CodCidadeNavigation")
                        .WithMany("TbLeitors")
                        .HasForeignKey("CodCidade")
                        .IsRequired()
                        .HasConstraintName("tb_leitor_ibfk_3");

                    b.HasOne("Bibliotecon.Models.Endereco", "CodEnderecoNavigation")
                        .WithMany("TbLeitors")
                        .HasForeignKey("CodEndereco")
                        .IsRequired()
                        .HasConstraintName("tb_leitor_ibfk_2");

                    b.HasOne("Bibliotecon.Models.Estado", "CodEstadoNavigation")
                        .WithMany("TbLeitors")
                        .HasForeignKey("CodEstado")
                        .IsRequired()
                        .HasConstraintName("tb_leitor_ibfk_1");

                    b.Navigation("CodCidadeNavigation");

                    b.Navigation("CodEnderecoNavigation");

                    b.Navigation("CodEstadoNavigation");
                });

            modelBuilder.Entity("Bibliotecon.Models.Reserva", b =>
                {
                    b.HasOne("Bibliotecon.Models.Exemplar", "CodExemplarNavigation")
                        .WithMany("TbReservas")
                        .HasForeignKey("CodExemplar")
                        .IsRequired()
                        .HasConstraintName("tb_reserva_ibfk_2");

                    b.HasOne("Bibliotecon.Models.Funcionario", "CodFuncionarioNavigation")
                        .WithMany("TbReservas")
                        .HasForeignKey("CodFuncionario")
                        .IsRequired()
                        .HasConstraintName("tb_reserva_ibfk_3");

                    b.HasOne("Bibliotecon.Models.Leitor", "CodLeitorNavigation")
                        .WithMany("TbReservas")
                        .HasForeignKey("CodLeitor")
                        .IsRequired()
                        .HasConstraintName("tb_reserva_ibfk_1");

                    b.Navigation("CodExemplarNavigation");

                    b.Navigation("CodFuncionarioNavigation");

                    b.Navigation("CodLeitorNavigation");
                });

            modelBuilder.Entity("Bibliotecon.Models.Cidade", b =>
                {
                    b.Navigation("TbEnderecos");

                    b.Navigation("TbFuncionarios");

                    b.Navigation("TbLeitors");
                });

            modelBuilder.Entity("Bibliotecon.Models.Endereco", b =>
                {
                    b.Navigation("TbFuncionarios");

                    b.Navigation("TbLeitors");
                });

            modelBuilder.Entity("Bibliotecon.Models.Estado", b =>
                {
                    b.Navigation("TbCidades");

                    b.Navigation("TbFuncionarios");

                    b.Navigation("TbLeitors");
                });

            modelBuilder.Entity("Bibliotecon.Models.Exemplar", b =>
                {
                    b.Navigation("TbDevolucaos");

                    b.Navigation("TbExemplarEmprestimos");

                    b.Navigation("TbReservas");
                });

            modelBuilder.Entity("Bibliotecon.Models.ExemplarEmprestimo", b =>
                {
                    b.Navigation("TbDevolucaos");
                });

            modelBuilder.Entity("Bibliotecon.Models.Funcionario", b =>
                {
                    b.Navigation("TbDevolucaos");

                    b.Navigation("TbExemplarEmprestimos");

                    b.Navigation("TbExemplars");

                    b.Navigation("TbReservas");
                });

            modelBuilder.Entity("Bibliotecon.Models.Leitor", b =>
                {
                    b.Navigation("TbExemplarEmprestimos");

                    b.Navigation("TbReservas");
                });

            modelBuilder.Entity("Bibliotecon.Models.Livro", b =>
                {
                    b.Navigation("TbExemplars");
                });
#pragma warning restore 612, 618
        }
    }
}