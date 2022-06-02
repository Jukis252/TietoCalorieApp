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

        [HttpGet]
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

    }
}
