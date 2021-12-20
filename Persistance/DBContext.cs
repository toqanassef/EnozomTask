using Application.Interfaces;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Application
{
    public partial class DBContext : DbContext, IDBContext
    {

        public DBContext(DbContextOptions<DBContext> options)
            : base(options)
        {
        }
        public DbSet<Country> Countries { get; set; }
        public DbSet<CountryHolidays> CountryHolidays { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DbContext).Assembly);
        }
        public override int SaveChanges()
        {
            // https://stackoverflow.com/questions/26908301/best-way-to-override-savechanges/26908556
            //https://stackoverflow.com/questions/60909477/ef-core-3-has-value-generator           
            return base.SaveChanges();
        }
    }
}
