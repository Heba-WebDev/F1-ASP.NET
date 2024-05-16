namespace formulaone.Controllers;

using formulaone.Data;
using formulaone.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// we're inherating from base because we don't want views
// if you want views, inhert from Controller not ControllerBase
[Route("/api/[controller]")]
[ApiController]
public class TeamsController : ControllerBase
{
    private static AppDbContext? _context;
    public TeamsController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var teams = await _context?.Teams.ToListAsync()!;
        return Ok(teams);
    }

    [HttpGet(template: "{id}")]
    public IActionResult Get(int id)
    {
        var team = _context?.Teams.FirstOrDefault(x => x.Id == id);
        if (team == null)
        {
            return NotFound("Team not found");
        }
        return Ok(team);
    }

    [HttpPost]
    public async Task<IActionResult> Post(Team team)
    {
        await _context!.Teams.AddAsync(team);
        await _context.SaveChangesAsync();
        return CreatedAtAction("Get", team.Id, team);
    }

    [HttpPatch]
    public async Task<IActionResult> Patch(int id, string country)
    {
        var team = await _context!.Teams.FirstOrDefaultAsync(x => x.Id == id);
        if (team == null)
        {
            return NotFound("Team not found");
        }
        team.Country = country;
        await _context!.SaveChangesAsync();
        return NoContent();
    }

    [HttpDelete]
    public async Task<IActionResult> Delete(int id)
    {
        var team = await _context!.Teams.FirstOrDefaultAsync(x => x.Id == id);
        if (team == null)
        {
            return NotFound("Team not found");
        }
        _context.Teams.Remove(team);
        await _context.SaveChangesAsync();
        return NoContent();
    }
}