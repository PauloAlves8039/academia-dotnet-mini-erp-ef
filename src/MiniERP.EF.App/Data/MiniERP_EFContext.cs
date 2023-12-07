using Microsoft.EntityFrameworkCore;
using MiniERP.EF.App.Models;

namespace MiniERP.EF.App.Data
{
    public partial class MiniERP_EFContext : DbContext
    {
        public MiniERP_EFContext() {}

        public MiniERP_EFContext(DbContextOptions<MiniERP_EFContext> options) : base(options) {}

        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Fornecedor> Fornecedors { get; set; }
        public virtual DbSet<ItemNotaFiscal> ItemNotaFiscals { get; set; }
        public virtual DbSet<NotaFiscal> NotaFiscals { get; set; }
        public virtual DbSet<Produto> Produtos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS;Initial Catalog=MiniERP_EF;Persist Security Info=True;User ID=sa;Password=*********");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => e.CodigoCliente)
                    .HasName("PK__Cliente__E0DD7E715BB88913");

                entity.ToTable("Cliente");

                entity.Property(e => e.Cpf)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("CPF");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Endereco)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Telefone)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Fornecedor>(entity =>
            {
                entity.HasKey(e => e.CodigoFornecedor)
                    .HasName("PK__Forneced__1FA78911D17DA8B9");

                entity.ToTable("Fornecedor");

                entity.Property(e => e.Cnpj)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CNPJ");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Endereco)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.RazaoSocial)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Telefone)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ItemNotaFiscal>(entity =>
            {
                entity.HasKey(e => e.CodigoItemNotaFiscal)
                    .HasName("PK__ItemNota__500D34F45549B9B2");

                entity.ToTable("ItemNotaFiscal");

                entity.Property(e => e.ValorUnitario).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.NotaFiscal)
                    .WithMany(p => p.ItemNotaFiscals)
                    .HasForeignKey(d => d.NotaFiscalId)
                    .HasConstraintName("FK__ItemNotaF__NotaF__403A8C7D");

                entity.HasOne(d => d.Produto)
                    .WithMany(p => p.ItemNotaFiscals)
                    .HasForeignKey(d => d.ProdutoId)
                    .HasConstraintName("FK__ItemNotaF__Produ__412EB0B6");
            });

            modelBuilder.Entity<NotaFiscal>(entity =>
            {
                entity.HasKey(e => e.CodigoNotaFiscal)
                    .HasName("PK__NotaFisc__BD26A989DBCE9C43");

                entity.ToTable("NotaFiscal");

                entity.Property(e => e.DataEmissao).HasColumnType("datetime");

                entity.Property(e => e.ValorTotal).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Cliente)
                    .WithMany(p => p.NotaFiscals)
                    .HasForeignKey(d => d.ClienteId)
                    .HasConstraintName("FK__NotaFisca__Clien__3D5E1FD2");
            });

            modelBuilder.Entity<Produto>(entity =>
            {
                entity.HasKey(e => e.CodigoProduto)
                    .HasName("PK__Produto__F94CC5B9A4DF4896");

                entity.ToTable("Produto");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Preco).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Descricao).HasMaxLength(250);

                entity.HasOne(d => d.Fornecedor)
                    .WithMany(p => p.Produtos)
                    .HasForeignKey(d => d.FornecedorId)
                    .HasConstraintName("FK__Produto__Fornece__3A81B327");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
