using Microsoft.EntityFrameworkCore;

namespace ProyectoFinal.Data
{
    public class ProyectoFinalDbContext : DbContext
    {
        public ProyectoFinalDbContext(DbContextOptions<ProyectoFinalDbContext> options) : base(options)
        {
        }

        public DbSet<ProyectoFinal.Models.Producto> Producto { get; set; } = default!;

        public DbSet<ProyectoFinal.Models.Cliente> Cliente { get; set; } = default!;

        public DbSet<ProyectoFinal.Models.Venta> Venta { get; set; } = default!;

        public DbSet<ProyectoFinal.Models.Proveedor> Proveedor { get; set; } = default!;

        
    }
}
