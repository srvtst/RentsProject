using Core.Entities.Concrate;
using Entities.Concrate;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrate.EntityFramework
{
    public class RentsContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<User>  Users { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }

        public RentsContext(DbContextOptions<RentsContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OperationClaim>().HasNoKey();
            modelBuilder.Entity<Car>().Property(x => x.DailyPrice).HasPrecision(5, 2);
            base.OnModelCreating(modelBuilder);
        }
    }
}