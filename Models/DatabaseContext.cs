using Microsoft.EntityFrameworkCore;

namespace GrupoGPS_Proto.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> opts): base(opts)
        {
            
        }
        public DbSet<Empresa> Empresa { get; set; }
    }
}
