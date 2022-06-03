using Microsoft.EntityFrameworkCore;
using TietoCalorieApp.Models;

namespace TietoCalorieApp.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Dish> Dishes { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<Nutrients> Nutrients { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Dish>();

            modelBuilder.Entity<Food>();
            modelBuilder.Entity<Nutrients>()
                .HasData(
                    new {Id = 1, Name = "Carbohydrates", CalorieCount = 4},
                    new {Id = 2, Name = "Protein", CalorieCount = 4},
                    new {Id = 3, Name = "Fats", CalorieCount = 9}
                    );


        }
    }
}
