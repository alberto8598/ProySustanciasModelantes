using Microsoft.EntityFrameworkCore;
using ModelingSubstances.Domain.Model;


namespace Vehiculos.DrivenAdapters.SqlServer
{
    public class SustaciaModelanteDbContext : DbContext
    {
        public SustaciaModelanteDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<SustanciaModelante> SustanciaModelante { get; set; }
    }
}
