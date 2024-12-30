using FoodRecipe.Data;
using FoodRecipe.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FoodRecipe.Controllers;


[ApiController]
[Route("food")]
public class FoodApiController : ControllerBase
{
    private readonly FoodDbContext foodDbContext;

    public FoodApiController(FoodDbContext foodDbContext)
    {
        this.foodDbContext = foodDbContext;
    }

    [HttpGet("/get/{id}")]
    public IActionResult GetParam(Guid id)
    {
        var x = foodDbContext.Foods.Include(f => f.Recipes).FirstOrDefault(e => e.Id == id);
        return Ok(x);
    }
    [HttpGet("/get-by-name/{name}")]
    public ActionResult<string> GetName(string name)
    {
        var a = foodDbContext.Foods.FirstOrDefault(c => c.FoodName == name);
        return Ok(a);
    }
    [HttpGet("get-all")]
    public ActionResult<List<Food>> GetAll()
    {
        var c = foodDbContext.Foods.OrderBy(x => x.FoodName).ToList();
        return Ok(c);
    }
    [HttpPost("/add")]
    public ActionResult Add(Food food)
    {
        var e = foodDbContext.Foods.Add(food);
        foodDbContext.SaveChanges();
        return Ok(e);
    }
    [HttpDelete("/delete/{id}")]
    public ActionResult Delete(Guid id)
    {
        var d = foodDbContext.Foods.FirstOrDefault(d => d.Id == id);
        foodDbContext.Foods.Remove(d);
        foodDbContext.SaveChanges();

        return Ok(d);
    }
    [HttpPut("/update-name")]
    public ActionResult Update([FromQuery] Guid id, [FromQuery] string name)
    {
        var f = foodDbContext.Foods.FirstOrDefault(f => f.Id == id);
        f.FoodName = name;
        foodDbContext.Foods.Update(f);
        foodDbContext.SaveChanges();
        return Ok(f);
    }

}
