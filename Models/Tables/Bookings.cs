using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace NorthwindAPI.Models.Tables;

[Table("Bookings")]
public class Booking
{
    [Key] public int Id { get; set; }
    
    public int RoomId { get; set; }
    [JsonIgnore] public Rooms Room { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public string ContactForename { get; set; }
    public string ContactSurname { get; set; }
    public string ContactEmail { get; set; }
    public bool CheckedIn { get; set; }
}