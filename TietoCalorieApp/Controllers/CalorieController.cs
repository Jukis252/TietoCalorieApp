﻿using Microsoft.AspNetCore.Mvc;
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

        [HttpGet("id")]
        public async Task<ActionResult<int>> GetFoodById(int id)
        {
            try
            {
                var foodById = await _caloriesService.GetFoodById(id);
                return Ok(foodById);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult> AddFood(GetFoodDTO addFoodDto)
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

        [HttpPut]
        public async Task<ActionResult> UpdateFood(GetFoodDTO newFood)
        {
            try
            {
                await _caloriesService.UpdateFood(newFood);
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
            await _caloriesService.DeleteFood(id);
            return Ok();
        }
    }
}
