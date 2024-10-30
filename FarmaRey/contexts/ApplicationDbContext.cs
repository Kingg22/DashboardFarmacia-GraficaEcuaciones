using FarmaRey.models;
using Microsoft.EntityFrameworkCore;

namespace FarmaRey.contexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Categoria> Categorias { get; set; }

        public DbSet<Medicamento> Medicamentos { get; set; }

        public DbSet<Venta> Ventas { get; set; }

        public DbSet<DetalleVenta> DetalleVenta { get; set; }

    }
}
