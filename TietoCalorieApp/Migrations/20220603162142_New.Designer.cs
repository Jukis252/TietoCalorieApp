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
    [Migration("20220603162142_New")]
    partial class New
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

                    b.Property<int>("CalorieCount")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Dishes");
                });

            modelBuilder.Entity("TietoCalorieApp.Models.Food", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CalorieCount")
                        .HasColumnType("int");

                    b.Property<int>("CarbsCount")
                        .HasColumnType("int");

                    b.Property<int>("FatsCount")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProteinCount")
                        .HasColumnType("int");

                    b.Property<int>("Weight")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Foods");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CalorieCount = 16,
                            CarbsCount = 9,
                            FatsCount = 0,
                            Name = "Tomato",
                            ProteinCount = 4,
                            Weight = 100
                        },
                        new
                        {
                            Id = 2,
                            CalorieCount = 47,
                            CarbsCount = 13,
                            FatsCount = 0,
                            Name = "Orange",
                            ProteinCount = 1,
                            Weight = 100
                        },
                        new
                        {
                            Id = 3,
                            CalorieCount = 15,
                            CarbsCount = 3,
                            FatsCount = 0,
                            Name = "Cucumber",
                            ProteinCount = 4,
                            Weight = 100
                        });
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
#pragma warning restore 612, 618
        }
    }
}