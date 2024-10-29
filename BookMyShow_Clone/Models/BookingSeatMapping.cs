using System;

namespace BookMyShow_Clone.Models;

public class BookingSeatMapping : BaseDomainEntity
{
    public int BookingId { get; set; }
    public Booking Booking { get; set; } = null!;

    public int SeatId { get; set; }
    public Seat Seat { get; set; } = null!;
}
