using System;

namespace BookMyShow_Clone.Models;

public class Booking : BaseDomainEntity
{
    public int ShowId { get; set; }
    public Show Show { get; set; } = null!;

    public string UserId { get; set; } = "";
    public User User { get; set; } = null!;

    public List<BookingSeatMapping> BookingSeats { get; set; } = new List<BookingSeatMapping>();
}
