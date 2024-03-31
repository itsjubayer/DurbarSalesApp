using DurbarSalesApp.Shared;
using Microsoft.EntityFrameworkCore;

namespace DurbarSalesApp.Server.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<RegionalOffice> RegionalOffices { get; set; }
        public DbSet<RegionalStore> RegionalStores { get; set; }
        public DbSet<DistrictSalesCentre> DistrictSalesCentre { get; set; }
        public DbSet<UpazillaSalesCentre> UpazillaSalesCentre { get; set; }
        public DbSet<GenerateList> GenerateListData { get; set; }
        
    }
}
