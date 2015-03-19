using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using SportsStore.Domain.Models.Mapping;

namespace SportsStore.Domain.Models
{
    public partial class SportsStoreContext : DbContext
    {
        static SportsStoreContext()
        {
            Database.SetInitializer<SportsStoreContext>(null);
        }

        public SportsStoreContext()
            : base("Name=SportsStoreContext")
        {
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProductMap());
        }



    }
}
