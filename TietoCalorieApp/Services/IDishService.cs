using Microsoft.AspNetCore.Mvc;
using TietoCalorieApp.Models.DTO;

namespace TietoCalorieApp.Services
{
    public interface IDishService
    {
        Task AddDish(DishDTO dishDto);
        Task<List<DishDTO>> GetAllDishAsync();
        Task<DishDTO> GetDishById(int id);
        Task DeleteDish (int id);
        Task UpdateDish(DishDTO dishDto);
    }
}
