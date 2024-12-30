using FoodRecipe.Data;
using FoodRecipe.Models;
using Microsoft.AspNetCore.Mvc;

namespace FoodRecipe.Controllers;
[ApiController]
[Route("recipe")]
public class RecipeController : ControllerBase
{
    private readonly FoodDbContext foodDbContext;

    public RecipeController(FoodDbContext foodDbContext)
    {
        this.foodDbContext = foodDbContext;
    }
    [HttpGet("/get-recipe/{id}")]
    public IActionResult GetParam(Guid id)
    {
        var x = foodDbContext.Recipes.FirstOrDefault(e => e.FoodId == id);
        return Ok(x);
    }
    [HttpGet("/get-recipe-by-food-id/{foodid}")]
    public IActionResult GetByFoodId(Guid foodid)
    {
        var a = foodDbContext.Recipes.FirstOrDefault(d => d.FoodId == foodid);
        return Ok(a);
    }
    [HttpGet("/get-by-description/{description}")]
    public ActionResult<string> GetName(string description)
    {
        var a = foodDbContext.Recipes.FirstOrDefault(c => c.Description == description);
        return Ok(a);
    }
    [HttpGet("get-all-recipe")]
    public ActionResult<List<Recipe>> GetAll()
    {
        var c = foodDbContext.Recipes.ToList();
        return Ok(c);
    }
    [HttpPost("/recipe-add")]
    public ActionResult Add(Recipe recipe)
    {
        var e = foodDbContext.Recipes.Add(recipe);
        foodDbContext.SaveChanges();
        return Ok(e);
    }
    [HttpDelete("/delete-recipe/{id}")]
    public ActionResult Delete(Guid id)
    {
        var d = foodDbContext.Recipes.FirstOrDefault(d => d.FoodId == id);
        foodDbContext.Recipes.Remove(d);
        foodDbContext.SaveChanges();

        return Ok(d);
    }
    [HttpPut("/update-description")]
    public ActionResult Update([FromQuery] Guid id, [FromQuery] string description)
    {
        var f = foodDbContext.Recipes.FirstOrDefault(f => f.FoodId == id);
        f.Description = description;
        foodDbContext.Recipes.Update(f);
        foodDbContext.SaveChanges();
        return Ok(f);
    }

}
