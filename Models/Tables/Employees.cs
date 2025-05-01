using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace NorthwindAPI.Models.Tables;

[Table("Employees")]
public class Employee
{
    [Key] public int Id { get; set; }
    public string Forename { get; set; }
    public string Surname { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public int DepartmentId { get; set; }
    [JsonIgnore] public Department Department { get; set; } = null;
}