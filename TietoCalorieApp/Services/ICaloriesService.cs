using Microsoft.AspNetCore.Mvc;
using TietoCalorieApp.Models.DTO;

namespace TietoCalorieApp.Services
{
    public interface ICaloriesService
    {
        Task<List<GetNutrientsDTO>> GetAllNutrientsAsync();
        Task AddFood(GetFoodDTO addFoodDto);
        Task<List<GetFoodDTO>> GetAllFoodAsync();
        Task<GetFoodDTO> GetFoodById(int id);
        Task DeleteFood (int id);
        Task UpdateFood(GetFoodDTO newFood);
    }
}
