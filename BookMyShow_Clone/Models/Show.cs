using System;

namespace BookMyShow_Clone.Models;

public class Show : BaseDomainEntity
{
    public DateTime Timing { get; set; }
    public int ScreenId { get; set; }
    public Screen Screen { get; set; } = null!;
    public int MovieId { get; set; }
    public Movie Movie { get; set; } = null!;

    public List<Booking> Bookings { get; set; } = new();
}
