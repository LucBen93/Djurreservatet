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
}
