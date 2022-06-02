namespace TietoCalorieApp.Models
{
    public class Nutrients
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CalorieCount { get; set; }
        public ICollection<Food> Food { get; set; }

    }
}
