using ContosoPets.Models;
using ContosoPets.Services;
using Microsoft.AspNetCore.Mvc;

namespace ContosoPets.Controllers;

[ApiController]
[Route("[controller]")]
public class PetController : ControllerBase
{
    private readonly IPetService _petService;

    public PetController(IPetService petService)
    {
        _petService = petService;
    }

    // GET all action
    [HttpGet]
    public ActionResult<List<Pet>> GetAll() => _petService.GetAll();

    // GET by id action
    [HttpGet("{id}")]
    public ActionResult<Pet> Get(int id)
    {
        var pet = _petService.Get(id);

        if (pet is null)
            return NotFound();

        return pet;
    }

    // POST action
    [HttpPost]
    public IActionResult Add(Pet pet)
    {
        _petService.Add(pet);

        return CreatedAtAction(nameof(Get), new { id = pet.Id }, pet);
    }
}
