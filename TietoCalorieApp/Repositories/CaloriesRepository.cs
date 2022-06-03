using Microsoft.EntityFrameworkCore;
using TietoCalorieApp.Data;
using TietoCalorieApp.Models;

namespace TietoCalorieApp.Repositories
{
    public class CaloriesRepository : ICaloriesRepository<Dish>
    {
        private readonly DataContext _dataContext;

        public CaloriesRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<List<Nutrients>> GetAllNutrientsAsync()
        {
            return await _dataContext.Nutrients.OrderByDescending(e => e.Id).ToListAsync();
        }

        public async Task AddFood(Food food)
        {
            await _dataContext.Foods.AddAsync(food);
            await _dataContext.SaveChangesAsync();
        }
    }
}
