using TietoCalorieApp.Models.DTO;

namespace TietoCalorieApp.Services
{
    public interface ICaloriesService
    {
        Task<List<GetNutrientsDTO>> GetAllNutrientsAsync();
    }
}
