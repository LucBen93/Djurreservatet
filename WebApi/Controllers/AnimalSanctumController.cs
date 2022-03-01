using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi.Models;
namespace WebApi.Controllers;

[ApiController]
[Route("Animals")]

public class AnimalSanctumController : ControllerBase
{

    AnimalSanctumContext _context;

    public AnimalSanctumController(AnimalSanctumContext context)
    {
        _context = context;
    }

    [HttpDelete]
    public async Task<ActionResult> DeleteAllHighScoreAsync()
    {
        _context.Animals.RemoveRange(_context.Animals);
        await _context.SaveChangesAsync();
        return NoContent();
    }

    [HttpGet]
    public async Task<ActionResult> GetHighScoreAsync()
    {
        var Animals = await _context.Animals.OrderBy(x => x.Time).Take(10).ToListAsync();
        if (Animals == null) return NotFound();
        else return Ok(Animals);
    }

    [HttpPost]
    public async Task<ActionResult<Animal>> PostAnimal(Animal animal)
    {
        if (string.IsNullOrWhiteSpace(animal.Name) || animal.Name.Length < 2 || animal.Name.Length > 15 || animal.Name.All(c => Char.IsDigit(c))) return BadRequest();
        else
        {
            _context.Animals.Add(animal);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetAnimalByIdAsync), new { id = animal.Id }, null);
        }
    }

    [HttpGet("id={id:int}")]
    [ActionName("GetAnimalByIdAsync")]
    public async Task<ActionResult<Animal>> GetAnimalByIdAsync(int id)
    {
        var animal = await _context.Animals.FindAsync(id);
        if (animal == null) return NotFound();
        else return Ok(animal);
    }

    [HttpGet("username={name}")]
    [ActionName("GetAnimalByUsernameAsync")]
    public async Task<ActionResult<List<Animal>>> GetAnimalByUsernameAsync(string name)
    {
        var Animals = await _context.Animals.Where(item => item.Name == name).ToListAsync();
        if (Animals.Count() == 0) return NotFound();
        else return Ok(Animals);
    }
}
