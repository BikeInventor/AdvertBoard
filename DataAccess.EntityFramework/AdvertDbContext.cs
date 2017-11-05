using System.Data.Entity;
using DataAccessLayer.Entities;

namespace DataAccess.EntityFramework
{
    public class AdvertDbContext : DbContext
    {
        public AdvertDbContext() : base("advert_db")
        {

        }

        public DbSet<User> Users { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<Advert> Adverts { get; set; }

        public DbSet<City> Cities { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
