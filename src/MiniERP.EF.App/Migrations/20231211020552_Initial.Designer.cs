﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MiniERP.EF.App.Data;

#nullable disable

namespace MiniERP.EF.App.Migrations
{
    [DbContext(typeof(MiniERP_EFContext))]
    [Migration("20231211020552_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MiniERP.EF.App.Models.Account.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("NomeUsuario")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            NomeUsuario = "Administrador",
                            Senha = "Abc@123456"
                        });
                });

            modelBuilder.Entity("MiniERP.EF.App.Models.Cliente", b =>
                {
                    b.Property<int>("CodigoCliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CodigoCliente"), 1L, 1);

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("CPF");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(150)
                        .IsUnicode(false)
                        .HasColumnType("varchar(150)");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(150)
                        .IsUnicode(false)
                        .HasColumnType("varchar(150)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnType("varchar(15)");

                    b.HasKey("CodigoCliente")
                        .HasName("PK__Cliente__E0DD7E715BB88913");

                    b.ToTable("Cliente", (string)null);
                });

            modelBuilder.Entity("MiniERP.EF.App.Models.Fornecedor", b =>
                {
                    b.Property<int>("CodigoFornecedor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CodigoFornecedor"), 1L, 1);

                    b.Property<string>("Cnpj")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("CNPJ");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(150)
                        .IsUnicode(false)
                        .HasColumnType("varchar(150)");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("RazaoSocial")
                        .IsRequired()
                        .HasMaxLength(150)
                        .IsUnicode(false)
                        .HasColumnType("varchar(150)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.HasKey("CodigoFornecedor")
                        .HasName("PK__Forneced__1FA78911D17DA8B9");

                    b.ToTable("Fornecedor", (string)null);
                });

            modelBuilder.Entity("MiniERP.EF.App.Models.ItemNotaFiscal", b =>
                {
                    b.Property<int>("CodigoItemNotaFiscal")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CodigoItemNotaFiscal"), 1L, 1);

                    b.Property<int?>("NotaFiscalId")
                        .HasColumnType("int");

                    b.Property<int?>("ProdutoId")
                        .HasColumnType("int");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.Property<decimal>("ValorUnitario")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("CodigoItemNotaFiscal")
                        .HasName("PK__ItemNota__500D34F45549B9B2");

                    b.HasIndex("NotaFiscalId");

                    b.HasIndex("ProdutoId");

                    b.ToTable("ItemNotaFiscal", (string)null);
                });

            modelBuilder.Entity("MiniERP.EF.App.Models.NotaFiscal", b =>
                {
                    b.Property<int>("CodigoNotaFiscal")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CodigoNotaFiscal"), 1L, 1);

                    b.Property<int?>("ClienteId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataEmissao")
                        .HasColumnType("datetime");

                    b.Property<decimal>("ValorTotal")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("CodigoNotaFiscal")
                        .HasName("PK__NotaFisc__BD26A989DBCE9C43");

                    b.HasIndex("ClienteId");

                    b.ToTable("NotaFiscal", (string)null);
                });

            modelBuilder.Entity("MiniERP.EF.App.Models.Produto", b =>
                {
                    b.Property<int>("CodigoProduto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CodigoProduto"), 1L, 1);

                    b.Property<string>("Descricao")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("Estoque")
                        .HasColumnType("int");

                    b.Property<int?>("FornecedorId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(150)
                        .IsUnicode(false)
                        .HasColumnType("varchar(150)");

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("CodigoProduto")
                        .HasName("PK__Produto__F94CC5B9A4DF4896");

                    b.HasIndex("FornecedorId");

                    b.ToTable("Produto", (string)null);
                });

            modelBuilder.Entity("MiniERP.EF.App.Models.ItemNotaFiscal", b =>
                {
                    b.HasOne("MiniERP.EF.App.Models.NotaFiscal", "NotaFiscal")
                        .WithMany("ItemNotaFiscals")
                        .HasForeignKey("NotaFiscalId")
                        .HasConstraintName("FK__ItemNotaF__NotaF__403A8C7D");

                    b.HasOne("MiniERP.EF.App.Models.Produto", "Produto")
                        .WithMany("ItemNotaFiscals")
                        .HasForeignKey("ProdutoId")
                        .HasConstraintName("FK__ItemNotaF__Produ__412EB0B6");

                    b.Navigation("NotaFiscal");

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("MiniERP.EF.App.Models.NotaFiscal", b =>
                {
                    b.HasOne("MiniERP.EF.App.Models.Cliente", "Cliente")
                        .WithMany("NotaFiscals")
                        .HasForeignKey("ClienteId")
                        .HasConstraintName("FK__NotaFisca__Clien__3D5E1FD2");

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("MiniERP.EF.App.Models.Produto", b =>
                {
                    b.HasOne("MiniERP.EF.App.Models.Fornecedor", "Fornecedor")
                        .WithMany("Produtos")
                        .HasForeignKey("FornecedorId")
                        .HasConstraintName("FK__Produto__Fornece__3A81B327");

                    b.Navigation("Fornecedor");
                });

            modelBuilder.Entity("MiniERP.EF.App.Models.Cliente", b =>
                {
                    b.Navigation("NotaFiscals");
                });

            modelBuilder.Entity("MiniERP.EF.App.Models.Fornecedor", b =>
                {
                    b.Navigation("Produtos");
                });

            modelBuilder.Entity("MiniERP.EF.App.Models.NotaFiscal", b =>
                {
                    b.Navigation("ItemNotaFiscals");
                });

            modelBuilder.Entity("MiniERP.EF.App.Models.Produto", b =>
                {
                    b.Navigation("ItemNotaFiscals");
                });
#pragma warning restore 612, 618
        }
    }
}