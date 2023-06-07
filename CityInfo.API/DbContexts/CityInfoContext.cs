using CityInfo.API.Entities;
using CityInfo.API.Models;
using Microsoft.EntityFrameworkCore;

namespace CityInfo.API.DbContexts
{
    public class CityInfoContext  : DbContext
    {
        public DbSet<City> Cities { get; set; } = null!;
        public DbSet<PointOfInterest> PointOfInterest { get; set; } = null!;

        public CityInfoContext(DbContextOptions<CityInfoContext> options) : base(options) 
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>().HasData(
                new City("Tijucas")
                {
                    Id = 1,
                    Description = "The dinosaur city"
                },
                new City("São João")
                {
                    Id = 2,
                    Description = "Something"
                },
                new City("Canelinha")
                {
                    Id = 3,
                    Description = "Small city",
                });

            modelBuilder.Entity<PointOfInterest>().HasData(
                new PointOfInterest("Tijusaur")
                {
                    Id = 1,
                    CityId = 1,
                    Description = "Our little baby"
                },
                new PointOfInterest("Praça Church")
                {
                    Id = 2,
                    CityId = 1,
                    Description = "Our beautiful church"
                },
                new PointOfInterest("Maybe the Square")
                {
                    Id = 3,
                    CityId = 2,
                    Description = "Must be nice"
                },
                new PointOfInterest("Koch")
                {
                    Id = 4,
                    CityId = 2,
                    Description = "Big supermarket"
                },
                new PointOfInterest("The mud")
                {
                    Id = 5,
                    CityId = 3,
                    Name = "The mud",
                    Description = "The mud there is nice"
                },
                new PointOfInterest("Cathedral")
                {
                    Id = 6,
                    CityId = 3,
                    Description = "Bigger church"
                });
            base.OnModelCreating(modelBuilder);
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlite("connectionString");
        //    base.OnConfiguring(optionsBuilder);
        //}
    }
}
