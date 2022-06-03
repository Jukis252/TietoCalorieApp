﻿using Microsoft.AspNetCore.Mvc;
using TietoCalorieApp.Models;
using TietoCalorieApp.Models.DTO;
using TietoCalorieApp.Repositories;

namespace TietoCalorieApp.Services
{
    public class CaloriesService : ICaloriesService
    {
        private readonly ICaloriesRepository<Dish> _caloriesRepository;

        public CaloriesService(ICaloriesRepository<Dish> caloriesRepository)
        {
            _caloriesRepository = caloriesRepository;
        }

        public async Task<List<GetNutrientsDTO>> GetAllNutrientsAsync()
        {
            var nutrientsFromDb = await _caloriesRepository.GetAllNutrientsAsync();
            var allNutrients = new List<GetNutrientsDTO>();
            foreach (var nutrient in nutrientsFromDb)
            {
                var nutrientsDto = new GetNutrientsDTO()
                {
                    CalorieCount = nutrient.CalorieCount,
                    Id = nutrient.Id,
                    Name = nutrient.Name,
                };
                allNutrients.Add(nutrientsDto);  
            }

            return allNutrients;
        }

        public async Task AddFood(GetFoodDTO addFoodDto)
        {
            var dbFood = new Food()
            {
                Name = addFoodDto.Name,
                Weight = addFoodDto.Weight,
                CalorieCount = addFoodDto.CalorieCount,
                CarbsCount = addFoodDto.CarbsCount,
                ProteinCount = addFoodDto.ProteinCount,
                FatsCount = addFoodDto.FatsCount,
            };
            await _caloriesRepository.AddFood(dbFood);
        }

        public async Task<List<GetFoodDTO>> GetAllFoodAsync()
        {
            var foodFromDb = await _caloriesRepository.GetAllFoodAsync();
            var allFood = new List<GetFoodDTO>();
            foreach (var food in foodFromDb)
            {
                var foodDto = new GetFoodDTO()
                {
                    Name = food.Name,
                    CalorieCount = food.CalorieCount,
                    FatsCount = food.FatsCount,
                    ProteinCount = food.ProteinCount,
                    CarbsCount = food.CarbsCount,
                    Weight = food.Weight
                };
                allFood.Add(foodDto);
            }

            return allFood;
        }

        public async Task<GetFoodDTO> GetFoodById(int id)
        {
            var foodFromDb = await _caloriesRepository.GetFoodById(id);

            var singleFood = new GetFoodDTO()
            {
                Id = foodFromDb.Id,
                Name = foodFromDb.Name,
                CalorieCount = foodFromDb.CalorieCount,
                FatsCount = foodFromDb.FatsCount,
                ProteinCount = foodFromDb.ProteinCount,
                CarbsCount = foodFromDb.CarbsCount,
                Weight = foodFromDb.Weight,
            };
            return singleFood;
        }

        public async Task DeleteFood(int id)
        {
            var foodFromDb = await _caloriesRepository.GetFoodById(id);
            await _caloriesRepository.DeleteFood(foodFromDb);
        }

        public async Task UpdateFood(GetFoodDTO newFood)
        {
            var food = await _caloriesRepository.GetFoodById(newFood.Id);
            newFood.Name = food.Name;
            newFood.CalorieCount = food.CalorieCount;
            newFood.FatsCount = food.FatsCount;
            newFood.ProteinCount = food.ProteinCount;
            newFood.CarbsCount = food.CarbsCount;
            newFood.Weight = food.Weight;
            await _caloriesRepository.UpdateFood();
        }

    }
}
