using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace NorthwindAPI.Models.Tables;

public class Employees
{
    [Key] public int Id { get; set; }
    public string Forename { get; set; }
    public string Surname { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public int DepartmentId { get; set; }
    [JsonIgnore] public Departments Department { get; set; } = null;
}