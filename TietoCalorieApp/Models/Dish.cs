namespace TietoCalorieApp.Models
{
    public class Dish
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int FoodId { get; set; }
        public ICollection<Food> Food { get; set; }


    }
}
