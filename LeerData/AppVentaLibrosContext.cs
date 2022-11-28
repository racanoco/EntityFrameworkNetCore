using Microsoft.EntityFrameworkCore;

namespace LeerData
{
    public class AppVentaLibrosContext : DbContext
    {
        private const string connectionString = "data source=.\\ANBU;initial catalog=LibrosWeb;user id=sa;password=ps015-j;persist security info=True;";
    
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Indico las dos claves primarias de la entidad LibroAutor
            modelBuilder.Entity<LibroAutor>().HasKey(xi => new {xi.AutorId, xi.LibroId});
        }

        public DbSet<Libro>? Libro {get;set;}
        public DbSet<Precio>? Precio {get;set;}
        public DbSet<Comentario>? Comentario {get;set;}
        public DbSet<Autor>? Autor {get;set;}
        public DbSet<LibroAutor>? LibroAutor {get;set;}
    }
}