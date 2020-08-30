using Bifrost.Model;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Bifrost.DL
{
    class BifrostDbContext : DbContext
    {
        public DbSet<BaseConfiguration> Configurations { get; set; }

        public BifrostDbContext() : base("BifrostDb")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
