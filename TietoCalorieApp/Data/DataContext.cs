﻿using Microsoft.EntityFrameworkCore;
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

            modelBuilder.Entity<Food>()
                .Property(f => f.Id).ValueGeneratedOnAdd();

            modelBuilder.Entity<Food>()
                .HasData(
                    new
                    {
                        Id = 1, Name = "Tomato", Weight = 100, CalorieCount = 16, CarbsCount = 9, ProteinCount = 4,
                        FatsCount = 0
                    },
                    new
                    {
                        Id = 2, Name = "Orange", Weight = 100, CalorieCount = 47, CarbsCount = 13, ProteinCount = 1,
                        FatsCount = 0
                    },
                    new
                    {
                        Id = 3, Name = "Cucumber", Weight = 100, CalorieCount = 15, CarbsCount = 3, ProteinCount = 4,
                        FatsCount = 0
                    }
                );

            modelBuilder.Entity<Nutrients>()
                .HasData(
                    new {Id = 1, Name = "Carbohydrates", CalorieCount = 4},
                    new {Id = 2, Name = "Protein", CalorieCount = 4},
                    new {Id = 3, Name = "Fats", CalorieCount = 9}
                    );


        }
    }
}
