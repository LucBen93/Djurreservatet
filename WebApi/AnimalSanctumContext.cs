using Microsoft.EntityFrameworkCore;
using WebApi.Models;
namespace WebApi;
public class AnimalSanctumContext : DbContext
{
    public AnimalSanctumContext(DbContextOptions<AnimalSanctumContext> options) : base(options)
    {

    }
    public DbSet<Animal> Animals { get; set; }
}