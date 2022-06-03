using Microsoft.AspNetCore.Mvc;
using TietoCalorieApp.Models.DTO;

namespace TietoCalorieApp.Services
{
    public interface IFoodService
    {
        Task<List<GetNutrientsDTO>> GetAllNutrientsAsync();
        Task AddFood(FoodDTO addFoodDto);
        Task<List<FoodDTO>> GetAllFoodAsync();
        Task<FoodDTO> GetFoodById(int id);
        Task DeleteFood (int id);
        Task UpdateFood(FoodDTO newFood);
    }
}
