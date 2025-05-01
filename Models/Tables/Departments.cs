using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NorthwindAPI.Models.Tables;

[Table("Departments")]
public class Department
{
    [Key] public int Id { get; set; }
    public string Name { get; set; }
}