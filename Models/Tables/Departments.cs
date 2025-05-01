using System.ComponentModel.DataAnnotations;

namespace NorthwindAPI.Models.Tables;

public class Departments
{
    [Key] public int Id { get; set; }
    public string Name { get; set; }
}