using Microsoft.AspNetCore.Mvc;
using TietoCalorieApp.Models.DTO;
using TietoCalorieApp.Services;

namespace TietoCalorieApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FoodController : ControllerBase
    {
        private readonly IFoodService _foodService;

        public FoodController(IFoodService foodService)
        {
            _foodService = foodService;
        }

        [HttpGet ("Nutrients/")]
        public async Task<ActionResult<List<GetNutrientsDTO>>> GetAllNutrients()
        {
            try
            {
                var allNutrients = await _foodService.GetAllNutrientsAsync();
                return Ok(allNutrients);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet]
        public async Task<ActionResult<List<FoodDTO>>> GetFood()
        {
            try
            {
                var allFood = await _foodService.GetAllFoodAsync();
                return Ok(allFood);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("id")]
        public async Task<ActionResult<int>> GetFoodById(int id)
        {
            try
            {
                var foodById = await _foodService.GetFoodById(id);
                return Ok(foodById);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult> AddFood(FoodDTO addFoodDto)
        {
            try
            {
                await _foodService.AddFood(addFoodDto);
                return NoContent();
            }
            catch (Exception)
            {
                return StatusCode(500, "Couldn't add food to menu.");
            }
        }

        [HttpPut]
        public async Task<ActionResult> UpdateFood(FoodDTO newFood)
        {
            try
            {
                await _foodService.UpdateFood(newFood);
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(500, "Couldn't update food.");
            }
        }
        [HttpDelete("id")]
        public async Task<ActionResult> DeleteFoodById(int id)
        {
            await _foodService.DeleteFood(id);
            return Ok();
        }
    }
}
