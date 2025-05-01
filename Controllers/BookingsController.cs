using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NorthwindAPI.Models;
using NorthwindAPI.Models.Tables;

namespace NorthwindAPI.Controllers;

[ApiController]
[Route("[controller]/")]
public class BookingsController(NorthwindDbContext context) : ControllerBase
{
    private NorthwindDbContext _dbContext = context;
    [HttpGet("fetch/all")]
    public async Task<IActionResult> FetchAll()
    {
        List<Rooms> allRooms = await _dbContext.Rooms.ToListAsync();
        return Ok(allRooms);
    }
}