namespace TietoCalorieApp.Models.DTO
{
    public class AddFoodDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Weight { get; set; }
        public int CalorieCount { get; set; }
        public double CarbsCount { get; set; }
        public double ProteinCount { get; set; }
        public double FatsCount { get; set; }

    }
}
