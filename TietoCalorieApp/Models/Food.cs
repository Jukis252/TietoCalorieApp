namespace TietoCalorieApp.Models
{
    public class Food
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CalorieCount { get; set; }
        public  Nutrients Nutrients { get; set; }
    }
}
