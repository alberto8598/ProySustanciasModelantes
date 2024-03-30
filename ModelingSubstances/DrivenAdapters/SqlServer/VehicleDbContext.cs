using Microsoft.EntityFrameworkCore;

using ModelingSubstances.Domain.Model;

namespace ModelingSubstances.DrivenAdapters.SqlServer
{
    public class VehicleDbContext : DbContext
    {
        public VehicleDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Transaccion> Transaccion { get; set; }
        
    }
}
