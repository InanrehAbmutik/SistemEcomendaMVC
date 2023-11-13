using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Dao
{
    public partial class Contexto : DbContext
    {
        public Contexto()
            : base("name=Contexto")
        {
        }

        public virtual DbSet<Categoria> Categorias { get; set; }
        public virtual DbSet<Ecomenda> Ecomendas { get; set; }
        public virtual DbSet<EstadoEncomenda> EstadoEncomendas { get; set; }
        public virtual DbSet<FormaPagamento> FormaPagamentoes { get; set; }
        public virtual DbSet<Produto> Produtoes { get; set; }
        public virtual DbSet<ProdutoEncomenda> ProdutoEncomendas { get; set; }
        public virtual DbSet<SatisfacaoEncomenda> SatisfacaoEncomendas { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categoria>()
                .Property(e => e.Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<Categoria>()
                .HasMany(e => e.Produtoes)
                .WithOptional(e => e.Categoria)
                .HasForeignKey(e => e.IdCategoria);

            modelBuilder.Entity<Ecomenda>()
                .Property(e => e.Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<Ecomenda>()
                .Property(e => e.Localizacao)
                .IsUnicode(false);

            modelBuilder.Entity<Ecomenda>()
                .HasMany(e => e.ProdutoEncomendas)
                .WithOptional(e => e.Ecomenda)
                .HasForeignKey(e => e.IdEncomenda);

            modelBuilder.Entity<EstadoEncomenda>()
                .Property(e => e.Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<EstadoEncomenda>()
                .HasMany(e => e.Ecomendas)
                .WithOptional(e => e.EstadoEncomenda)
                .HasForeignKey(e => e.IdEstado);

            modelBuilder.Entity<FormaPagamento>()
                .Property(e => e.Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<FormaPagamento>()
                .HasMany(e => e.Ecomendas)
                .WithOptional(e => e.FormaPagamento)
                .HasForeignKey(e => e.IdForma);

            modelBuilder.Entity<Produto>()
                .Property(e => e.Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<Produto>()
                .Property(e => e.ImgCaminho)
                .IsUnicode(false);

            modelBuilder.Entity<Produto>()
                .HasMany(e => e.ProdutoEncomendas)
                .WithOptional(e => e.Produto)
                .HasForeignKey(e => e.IdProduto);

            modelBuilder.Entity<SatisfacaoEncomenda>()
                .Property(e => e.Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<SatisfacaoEncomenda>()
                .HasMany(e => e.Ecomendas)
                .WithOptional(e => e.SatisfacaoEncomenda)
                .HasForeignKey(e => e.IdSatisfacao);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Senha)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Telefone)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Nome)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.Ecomendas)
                .WithOptional(e => e.Usuario)
                .HasForeignKey(e => e.IdCliente);
        }
    }
}
