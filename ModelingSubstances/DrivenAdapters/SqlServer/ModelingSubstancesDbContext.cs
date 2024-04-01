using Microsoft.EntityFrameworkCore;

using ModelingSubstances.Domain.Model;

namespace ModelingSubstances.DrivenAdapters.SqlServer
{
    public class ModelingSubstancesDbContext : DbContext
    {
        public ModelingSubstancesDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Transaccion> Transaccion { get; set; }
        
    }
}
