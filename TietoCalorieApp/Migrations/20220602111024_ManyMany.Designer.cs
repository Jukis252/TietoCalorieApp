﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TietoCalorieApp.Data;

#nullable disable

namespace TietoCalorieApp.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220602111024_ManyMany")]
    partial class ManyMany
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("TietoCalorieApp.Models.Dish", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("FoodId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Dishes");
                });

            modelBuilder.Entity("TietoCalorieApp.Models.DishFood", b =>
                {
                    b.Property<int>("DishId")
                        .HasColumnType("int");

                    b.Property<int>("FoodId")
                        .HasColumnType("int");

                    b.HasKey("DishId", "FoodId");

                    b.HasIndex("FoodId");

                    b.ToTable("DishFoods");
                });

            modelBuilder.Entity("TietoCalorieApp.Models.Food", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CalorieCount")
                        .HasColumnType("int");

                    b.Property<int>("DishId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NutrientId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NutrientId");

                    b.ToTable("Foods");
                });

            modelBuilder.Entity("TietoCalorieApp.Models.Nutrients", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CalorieCount")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Nutrients");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CalorieCount = 4,
                            Name = "Carbohydrates"
                        },
                        new
                        {
                            Id = 2,
                            CalorieCount = 4,
                            Name = "Protein"
                        },
                        new
                        {
                            Id = 3,
                            CalorieCount = 9,
                            Name = "Fats"
                        });
                });

            modelBuilder.Entity("TietoCalorieApp.Models.DishFood", b =>
                {
                    b.HasOne("TietoCalorieApp.Models.Dish", null)
                        .WithMany()
                        .HasForeignKey("DishId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TietoCalorieApp.Models.Food", null)
                        .WithMany()
                        .HasForeignKey("FoodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TietoCalorieApp.Models.Food", b =>
                {
                    b.HasOne("TietoCalorieApp.Models.Nutrients", "Nutrients")
                        .WithMany("Food")
                        .HasForeignKey("NutrientId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Nutrients");
                });

            modelBuilder.Entity("TietoCalorieApp.Models.Nutrients", b =>
                {
                    b.Navigation("Food");
                });
#pragma warning restore 612, 618
        }
    }
}