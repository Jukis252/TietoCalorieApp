using Microsoft.AspNetCore.Mvc;
using TietoCalorieApp.Models;

namespace TietoCalorieApp.Repositories
{
    public interface IDishRepository<T> where T : class
    {
        Task AddDish(Dish dish);
        Task<List<Dish>> GetAllDishesAsync();
        Task<Dish?> GetDishById(int id);
        Task DeleteDish (Dish dish);
        Task UpdateDish();
    }
}
