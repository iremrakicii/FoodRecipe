namespace FoodRecipe.Models;

public class Food : BaseEntity
{
    public string FoodName { get; set; } = string.Empty;

    public string FoodVariety { get; set; } = string.Empty;

    public string FoodPhoto { get; set; } = string.Empty;

    public ICollection<Recipe> Recipes { get; set; } = new List<Recipe>();

}
