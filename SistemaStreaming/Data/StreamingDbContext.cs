using Microsoft.EntityFrameworkCore;
using SistemaStreaming.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaStreaming.Data
{
    public class StreamingDbContext : DbContext
    {
        protected StreamingDbContext(DbContextOptions<StreamingDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AtorFilme>().HasKey(af => new { af.AtorId,af.FilmeId});

            modelBuilder.Entity<FilmeCategoria>().HasKey(af => new { af.CategoriaId, af.FilmeId });
        }

        public DbSet<Filme> Filmes { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Ator> Atores { get; set; }
        public DbSet<Produtor> Produtores { get; set; }
        public DbSet<AtorFilme> AtoresFilmes { get; set; }
        public DbSet<FilmeCategoria> FilmesCategorias { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }

    }
}
