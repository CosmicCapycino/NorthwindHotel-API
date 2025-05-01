using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NorthwindAPI.Models;
using NorthwindAPI.Models.Tables;

namespace NorthwindAPI.Controllers;

[ApiController]
[Route("[controller]/")]
public class EmployeesController(NorthwindDbContext context) : ControllerBase
{
    private NorthwindDbContext _dbContext = context;
    
    [HttpGet("fetch/{department}")]
    public async Task<IActionResult> FetchByDepartment(string department)
    {
        List<Employees> allRooms = await _dbContext.Employees.Where(x => x.Department.Name == department).ToListAsync();
        return Ok(allRooms);
    }
}