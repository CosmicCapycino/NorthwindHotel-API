using Azure.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NorthwindAPI.Models;
using NorthwindAPI.Models.Tables;

namespace NorthwindAPI.Controllers;

[ApiController]
[Route("[controller]/")]
public class AuthController(NorthwindDbContext context) : ControllerBase
{
    private NorthwindDbContext _dbContext = context;

    [HttpPost("login")]
    public async Task<IActionResult> LoginUser([FromForm] string username, [FromForm] string password)
    {
        User? exisitngUser = await _dbContext.Users.Where(e => e.Username == username.ToLower()).Include(x => x.Employee).FirstOrDefaultAsync();
        if (exisitngUser != null)
        {
            if (password == exisitngUser.Password)
            {
                return Ok(new 
                {
                    Forename = exisitngUser.Employee.Forename,
                    Surname = exisitngUser.Employee.Surname,
                    Email = exisitngUser.Employee.Email,
                    Phone = exisitngUser.Employee.Phone,
                    Role = exisitngUser.Role
                });
            }
            else
            {
                return BadRequest();
            }
        }
        else
        {
            return BadRequest();
        }
    }
}