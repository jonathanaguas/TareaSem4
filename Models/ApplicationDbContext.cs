using BibliotecaApp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BibliotecaApp.Data
{
   
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Libro> Libros { get; set; }
        public DbSet<Miembro> Miembros { get; set; }
        public DbSet<Prestamo> Prestamos { get; set; }
    }

}