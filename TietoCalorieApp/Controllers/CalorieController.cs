using Microsoft.AspNetCore.Mvc;
using TietoCalorieApp.Services;

namespace TietoCalorieApp.Controllers
{
    [ApiController]
    [Route("[controller")]
    public class CalorieController : ControllerBase
    {
        private readonly ICaloriesService _caloriesService;

    }
}
