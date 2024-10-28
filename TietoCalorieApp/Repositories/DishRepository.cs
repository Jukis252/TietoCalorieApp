using Microsoft.EntityFrameworkCore;
using TietoCalorieApp.Data;
using TietoCalorieApp.Models;

namespace TietoCalorieApp.Repositories
{
    public class DishRepository : IDishRepository<Dish>
    {
        private readonly DataContext _dataContext;

        public DishRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        
        public async Task AddDish(Dish dish)
        {
            await _dataContext.Dishes.AddAsync(dish);
            await _dataContext.SaveChangesAsync();
        }

        public async Task<List<Dish>> GetAllDishesAsync()
        {
            return await _dataContext.Dishes.OrderByDescending(e => e.Id).ToListAsync();
        }

        public async Task DeleteDish (Dish dish)
        {
            _dataContext.Dishes.Remove(dish);
            await _dataContext.SaveChangesAsync();
        }

        public async Task<Dish?> GetDishById(int id)
        { 
            return await _dataContext.Dishes.FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task UpdateDish()
        {
             _dataContext.SaveChanges();
        }

    }
}
