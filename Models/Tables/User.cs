using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace NorthwindAPI.Models.Tables;

[Table("Users")]
public class User
{
    [Key] public int UserID { get; set; }
    public int EmployeeID { get; set; }
    [JsonIgnore] public Employee Employee { get; set; } = null;
    public string Username { get; set; }
    public string Password { get; set; }
    public string Role { get; set; }
}