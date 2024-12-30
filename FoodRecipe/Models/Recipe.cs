using System.Text.Json.Serialization;

namespace FoodRecipe.Models;

public class Recipe : BaseEntity
{
    public string Description { get; set; } = string.Empty;

    public Guid FoodId { get; set; } = default!;

    [JsonIgnore]
    public Food? Food { get; set; }
}
