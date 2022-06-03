using Microsoft.AspNetCore.Mvc;
using TietoCalorieApp.Models.DTO;
using TietoCalorieApp.Services;

namespace TietoCalorieApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalorieController : ControllerBase
    {
        private readonly ICaloriesService _caloriesService;

        public CalorieController(ICaloriesService caloriesService)
        {
            _caloriesService = caloriesService;
        }

        [HttpGet ("Nutrients/")]
        public async Task<ActionResult<List<GetNutrientsDTO>>> GetAllNutrients()
        {
            try
            {
                var allNutrients = await _caloriesService.GetAllNutrientsAsync();
                return Ok(allNutrients);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult> AddFood(AddFoodDTO addFoodDto)
        {
            try
            {
                await _caloriesService.AddFood(addFoodDto);
                return NoContent();
            }
            catch (Exception)
            {
                return StatusCode(500, "Couldn't add food to menu.");
            }
        }

        [HttpGet]
        public async Task<ActionResult<List<GetFoodDTO>>> GetFood()
        {
            try
            {
                var allFood = await _caloriesService.GetAllFoodAsync();
                return Ok(allFood);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
