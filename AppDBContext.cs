using System;
using Task15.Models;
using Microsoft.EntityFrameworkCore;
namespace Task15
{
    public class AppDBContext:DbContext
    {
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = Cities.db;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>().Navigation(x => x.Cities).AutoInclude();
            modelBuilder.Entity<City>().Navigation(x => x.Country).AutoInclude();
        }

        public AppDBContext() : base() { }
    }
}
