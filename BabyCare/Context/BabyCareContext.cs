using BabyCare.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace BabyCare.Context
{
    public class BabyCareContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=MEHMET\\SQLEXPRESS;initial catalog=BabyCareDb;integrated security=true;");
        }

        public DbSet<Feature> Features { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<AboutList> AboutLists { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Team> Teams { get; set; }
    }
}
