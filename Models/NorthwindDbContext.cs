using Microsoft.EntityFrameworkCore;
using NorthwindAPI.Models.Tables;

namespace NorthwindAPI.Models;

public partial class NorthwindDbContext : DbContext
{
    public NorthwindDbContext(DbContextOptions<NorthwindDbContext> options) : base(options) {}
    
    public DbSet<Rooms> Rooms { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Booking> Bookings { get; set; }
    public DbSet<User> Users { get; set; }
}