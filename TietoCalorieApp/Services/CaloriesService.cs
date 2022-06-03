using Microsoft.AspNetCore.Mvc;
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
                var nutrientsDTO = new GetNutrientsDTO()
                {
                    CalorieCount = nutrient.CalorieCount,
                    Id = nutrient.Id,
                    Name = nutrient.Name,
                };
                allNutrients.Add(nutrientsDTO);  
            }

            return allNutrients;
        }

        public async Task AddFood(AddFoodDTO addFoodDto)
        {
            var dbFood = new Food()
            {
                Name = addFoodDto.Name,
                Weight = addFoodDto.Weight,
                CarbsCount = addFoodDto.CarbsCount,
                ProteinCount = addFoodDto.ProteinCount,
                FatsCount = addFoodDto.FatsCount,
                CalorieCount = addFoodDto.CalorieCount,

            };
            await _caloriesRepository.AddFood(dbFood);
        }

    }
}
