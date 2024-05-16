namespace formulaone.Data;

using formulaone.Models;
using Microsoft.EntityFrameworkCore;


public class AppDbContext : DbContext
{
    public DbSet<Team> Teams { get; set; }
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }
}