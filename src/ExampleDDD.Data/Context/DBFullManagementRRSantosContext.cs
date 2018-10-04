namespace ExampleDDD.Data.Context
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using ExampleDDD.Domain.Entities;

    public partial class DBFullManagementRRSantosContext : DbContext
    {
        public DBFullManagementRRSantosContext()
            : base("name=DBFullManagementRRSantosContext")
        {
        }

        public virtual DbSet<Empresas> Empresas { get; set; }
        public virtual DbSet<Estados> Estados { get; set; }
        public virtual DbSet<Municipios> Municipios { get; set; }
        public virtual DbSet<Paises> Paises { get; set; }
        public virtual DbSet<TipoLogradouros> TipoLogradouros { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Empresas>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<Empresas>()
                .Property(e => e.RazaoSocial)
                .IsUnicode(false);

            modelBuilder.Entity<Empresas>()
                .Property(e => e.Logradouro)
                .IsUnicode(false);

            modelBuilder.Entity<Empresas>()
                .Property(e => e.Numero)
                .IsUnicode(false);

            modelBuilder.Entity<Empresas>()
                .Property(e => e.Complemento)
                .IsUnicode(false);

            modelBuilder.Entity<Empresas>()
                .Property(e => e.Bairro)
                .IsUnicode(false);

            modelBuilder.Entity<Empresas>()
                .Property(e => e.Cep)
                .IsUnicode(false);

            modelBuilder.Entity<Empresas>()
                .Property(e => e.Tipo)
                .IsUnicode(false);

            modelBuilder.Entity<Empresas>()
                .Property(e => e.CnpjCpf)
                .IsUnicode(false);

            modelBuilder.Entity<Estados>()
                .Property(e => e.CodigoIbge)
                .IsUnicode(false);

            modelBuilder.Entity<Estados>()
                .Property(e => e.Sigla)
                .IsUnicode(false);

            modelBuilder.Entity<Estados>()
                .Property(e => e.Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<Estados>()
                .HasMany(e => e.Empresas)
                .WithRequired(e => e.Estados)
                .HasForeignKey(e => e.IdEstado)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Estados>()
                .HasMany(e => e.Municipios)
                .WithRequired(e => e.Estados)
                .HasForeignKey(e => e.IdEstado)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Municipios>()
                .Property(e => e.CodigoIbge)
                .IsUnicode(false);

            modelBuilder.Entity<Municipios>()
                .Property(e => e.Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<Municipios>()
                .HasMany(e => e.Empresas)
                .WithRequired(e => e.Municipios)
                .HasForeignKey(e => e.IdMunicipio)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Paises>()
                .Property(e => e.CodigoIbge)
                .IsUnicode(false);

            modelBuilder.Entity<Paises>()
                .Property(e => e.CodigoSiscomex)
                .IsUnicode(false);

            modelBuilder.Entity<Paises>()
                .Property(e => e.Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<Paises>()
                .HasMany(e => e.Empresas)
                .WithRequired(e => e.Paises)
                .HasForeignKey(e => e.IdPais)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TipoLogradouros>()
                .Property(e => e.Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<TipoLogradouros>()
                .HasMany(e => e.Empresas)
                .WithOptional(e => e.TipoLogradouros)
                .HasForeignKey(e => e.IdTipoLogradouro);
        }
    }
}
