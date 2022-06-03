using Microsoft.AspNetCore.Mvc;
using TietoCalorieApp.Models.DTO;

namespace TietoCalorieApp.Services
{
    public interface ICaloriesService
    {
        Task<List<GetNutrientsDTO>> GetAllNutrientsAsync();
        Task AddFood(AddFoodDTO addFoodDto);
    }
}
