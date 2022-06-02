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

    }
}
