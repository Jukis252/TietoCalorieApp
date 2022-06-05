using Microsoft.AspNetCore.Mvc;
using TietoCalorieApp.Models;
using TietoCalorieApp.Models.DTO;
using TietoCalorieApp.Repositories;

namespace TietoCalorieApp.Services
{
    public class DishService : IDishService
    {
        private readonly IDishRepository<Dish> _dishRepository;

        public DishService(IDishRepository<Dish> dishRepository)
        {
            _dishRepository = dishRepository;
        }
        
        public async Task AddDish(DishDTO dishDto)
        {
            var dbDish = new Dish()
            {
                Name = dishDto.Name,
                Weight = dishDto.Weight,
                CalorieCount = dishDto.CalorieCount,
                CarbsCount = dishDto.CarbsCount,
                ProteinCount = dishDto.ProteinCount,
                FatsCount = dishDto.FatsCount,
            };
            await _dishRepository.AddDish(dbDish);
        }

        public async Task<List<DishDTO>> GetAllDishAsync()
        {
            var dishFromDb = await _dishRepository.GetAllDishesAsync();
            var allDishes = new List<DishDTO>();
            foreach (var dish in dishFromDb)
            {
                var dishDto = new DishDTO()
                {
                    Id= dish.Id,
                    Name = dish.Name,
                    CalorieCount = dish.CalorieCount,
                    FatsCount = dish.FatsCount,
                    ProteinCount = dish.ProteinCount,
                    CarbsCount = dish.CarbsCount,
                    Weight = dish.Weight
                };
                allDishes.Add(dishDto);
            }
            return allDishes;
        }

        public async Task<DishDTO> GetDishById(int id)
        {
            var dishFromDB = await _dishRepository.GetDishById(id);

            var singelDish = new DishDTO()
            {
                Id = dishFromDB.Id,
                Name = dishFromDB.Name,
                CalorieCount = dishFromDB.CalorieCount,
                FatsCount = dishFromDB.FatsCount,
                ProteinCount = dishFromDB.ProteinCount,
                CarbsCount = dishFromDB.CarbsCount,
                Weight = dishFromDB.Weight,
            };
            return singelDish;
        }

        public async Task DeleteDish(int id)
        {
            var dishFromDb = await _dishRepository.GetDishById(id);
            await _dishRepository.DeleteDish(dishFromDb);
        }

        public async Task UpdateDish(DishDTO dishDto)
        {
            var dish = await _dishRepository.GetDishById(dishDto.Id);
            dish.Name = dishDto.Name;
            dish.Weight = dishDto.Weight;
            dish.FatsCount = dishDto.FatsCount;
            dish.ProteinCount = dishDto.ProteinCount;
            dish.CarbsCount = dishDto.CarbsCount;
            dish.CalorieCount = dishDto.CalorieCount;
            await _dishRepository.UpdateDish();
        }

    }
}
