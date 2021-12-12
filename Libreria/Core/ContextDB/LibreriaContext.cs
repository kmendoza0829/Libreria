using Libreria.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Libreria.Core.ContextDB
{
    public class LibreriaContext :DbContext
    {
        public LibreriaContext(DbContextOptions<LibreriaContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AutorLibro>()
                .HasKey(t => new { t.AutorId, t.LibroId });

            modelBuilder.Entity<AutorLibro>()
                .HasOne(pt => pt.Autor)
                .WithMany(p => p.AutorLibro)
                .HasForeignKey(pt => pt.AutorId);

            modelBuilder.Entity<AutorLibro>()
                .HasOne(pt => pt.Libro)
                .WithMany(t => t.AutorLibro)
                .HasForeignKey(pt => pt.LibroId);
        }

        public DbSet<Editorial> Editorial { get; set; }
        public DbSet<Autor> Autor { get; set; }
        public DbSet<Libro> Libro { get; set; }
        public DbSet<AutorLibro> AutorLibro { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }
    }
}
