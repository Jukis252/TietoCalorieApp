using Microsoft.AspNetCore.Mvc;
using TietoCalorieApp.Models.DTO;
using TietoCalorieApp.Services;

namespace TietoCalorieApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DishController : ControllerBase
    {
        private readonly IDishService _dishService;

        public DishController(IDishService dishService)
        {
            _dishService = dishService;
        }


        [HttpGet]
        public async Task<ActionResult<List<DishDTO>>> GetAllDishes()
        {
            try
            {
                var allDish = await _dishService.GetAllDishAsync();
                return Ok(allDish);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("id")]
        public async Task<ActionResult<int>> GetDishById(int id)
        {
            try
            {
                var dishById = await _dishService.GetDishById(id);
                return Ok(dishById);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult> AddDish(DishDTO dishDto)
        {
            try
            {
                await _dishService.AddDish(dishDto);
                return NoContent();
            }
            catch (Exception)
            {
                return StatusCode(500, "Couldn't add dish to menu.");
            }
        }

        [HttpPut]
        public async Task<ActionResult> UpdateDish(DishDTO dishDto)
        {
            try
            {
                await _dishService.UpdateDish(dishDto);
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(500, "Couldn't update dish.");
            }
        }
        [HttpDelete("id")]
        public async Task<ActionResult> DeleteDishById(int id)
        {
            await _dishService.DeleteDish(id);
            return Ok();
        }
    }
}
