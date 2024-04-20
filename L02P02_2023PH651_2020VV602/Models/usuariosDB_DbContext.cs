using Microsoft.EntityFrameworkCore;

namespace L02P02_2023PH651_2020VV602.Models
{
    public class usuariosDB_DbContext : DbContext
    {
        public usuariosDB_DbContext(DbContextOptions<usuariosDB_DbContext> options) : base(options) { }

        public DbSet<clientes> clientes { get; set; }
        public DbSet<departamentos> departamentos { get; set; }
        public DbSet<puestos> puestos { get; set; }

    }
}
