using Microsoft.EntityFrameworkCore;
using TietoCalorieApp.Models;

namespace TietoCalorieApp.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Dish> Dish { get; set; }
        public DbSet<Food> Food { get; set; }
        public DbSet<Nutrients> Nutrients { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Nutrients>()
                .HasData(
                    new {Id = 1, Name = "Carbohydrates"},
                    new {Id = 2, Name = "Protein"},
                    new {Id = 3, Name = "Fats"}
                    );


        }
    }
}
