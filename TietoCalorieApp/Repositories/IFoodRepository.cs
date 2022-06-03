using Microsoft.AspNetCore.Mvc;
using TietoCalorieApp.Models;

namespace TietoCalorieApp.Repositories
{
    public interface IFoodRepository<T> where T : class
    {
        Task<List<Nutrients>> GetAllNutrientsAsync();
        Task AddFood(Food food);
        Task<List<Food>> GetAllFoodAsync();
        Task DeleteFood (Food food);
        Task<Food?> GetFoodById(int id);
        Task UpdateFood();
    }
}
