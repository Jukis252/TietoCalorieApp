﻿using Microsoft.AspNetCore.Mvc;
using TietoCalorieApp.Models;
using TietoCalorieApp.Models.DTO;
using TietoCalorieApp.Repositories;

namespace TietoCalorieApp.Services
{
    public class FoodService : IFoodService
    {
        private readonly IFoodRepository<Dish> _foodRepository;

        public FoodService(IFoodRepository<Dish> foodRepository)
        {
            _foodRepository = foodRepository;
        }

        public async Task<List<GetNutrientsDTO>> GetAllNutrientsAsync()
        {
            var nutrientsFromDb = await _foodRepository.GetAllNutrientsAsync();
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

        public async Task AddFood(FoodDTO addFoodDto)
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
            await _foodRepository.AddFood(dbFood);
        }

        public async Task<List<FoodDTO>> GetAllFoodAsync()
        {
            var foodFromDb = await _foodRepository.GetAllFoodAsync();
            var allFood = new List<FoodDTO>();
            foreach (var food in foodFromDb)
            {
                var foodDto = new FoodDTO()
                {
                    Id= food.Id,
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

        public async Task<FoodDTO> GetFoodById(int id)
        {
            var foodFromDb = await _foodRepository.GetFoodById(id);

            var singleFood = new FoodDTO()
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
            var foodFromDb = await _foodRepository.GetFoodById(id);
            await _foodRepository.DeleteFood(foodFromDb);
        }

        public async Task UpdateFood(FoodDTO newFood)
        {
            var food = await _foodRepository.GetFoodById(newFood.Id);
            newFood.Name = food.Name;
            newFood.CalorieCount = food.CalorieCount;
            newFood.FatsCount = food.FatsCount;
            newFood.ProteinCount = food.ProteinCount;
            newFood.CarbsCount = food.CarbsCount;
            newFood.Weight = food.Weight;
            await _foodRepository.UpdateFood();
        }

    }
}