namespace TietoCalorieApp.Models.DTO
{
    public class DishDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CalorieCount { get; set; }
        public int Weight { get; set; }
        public int CarbsCount { get; set; }
        public int ProteinCount { get; set; }
        public int FatsCount { get; set; }
    }
}
