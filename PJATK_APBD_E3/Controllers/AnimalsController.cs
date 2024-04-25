using Microsoft.AspNetCore.Mvc;
using PJATK_APBD_E3.Models;
using PJATK_APBD_E3.Services;

namespace PJATK_APBD_E3.Controllers;

[Route("api/animals")]
[ApiController]
public class AnimalsController : ControllerBase
{
    
    private IAnimalsService _animalsService;
    
    public AnimalsController(IAnimalsService animalsService)
    {
        _animalsService = animalsService;
    }
    
    
    [HttpGet]
    public IActionResult GetAnimals([FromQuery] string orderBy="name")
    {
        var animals = _animalsService.GetAnimals(orderBy);
        return Ok(animals);
    }
    
    [HttpPost]
    public IActionResult AddAnimal(Animal animal)
    {
        _animalsService.AddAnimal(animal);
        return StatusCode((StatusCodes.Status201Created));
    }
    
    [HttpPut("{id:int}")]
    public IActionResult UpdateAnimal(int id, [FromBody] Animal animal)
    {
        _animalsService.UpdateAnimal(animal);
        return NoContent();
    }
    
    [HttpDelete("{id:int}")]
    public IActionResult DeleteAnimal(int id)
    {
        _animalsService.DeleteAnimal(id);
        return NoContent();
    }
    
}