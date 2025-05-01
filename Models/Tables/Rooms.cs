using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace NorthwindAPI.Models.Tables;

public class Rooms
{
    [Key] public int RoomId { get; set; }
    public int RoomNumber { get; set; }
    public bool NeedsCleaning { get; set; }
}