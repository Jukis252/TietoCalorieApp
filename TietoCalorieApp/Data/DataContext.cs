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
        public DbSet<DishFood> DishFoods { get; set; }
        public DbSet<Nutrients> Nutrients { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Dish>()
                .HasMany(f => f.Food)
                .WithMany(f => Dishes)
                .UsingEntity<DishFood>(
                    r => r.HasOne<Food>().WithMany().HasForeignKey(l => l.FoodId),
                    l => l.HasOne<Dish>().WithMany().HasForeignKey(l => l.DishId),
                    je =>
                    {
                        je.HasKey("DishId", "FoodId");
                    }
                );

            modelBuilder.Entity<Food>()
                .HasOne(f => f.Nutrients)
                .WithMany(n => n.Food)
                .HasForeignKey(f => f.NutrientId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Nutrients>()
                .HasData(
                    new {Id = 1, Name = "Carbohydrates", CalorieCount = 4},
                    new {Id = 2, Name = "Protein", CalorieCount = 4},
                    new {Id = 3, Name = "Fats", CalorieCount = 9}
                    );


        }
    }
}
