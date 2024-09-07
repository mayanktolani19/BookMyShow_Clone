using System;

namespace BookMyShow_Clone.Models;

public class Seat : BaseDomainEntity
{
    public int SeatNumber { get; set; }
    public int RowNumber { get; set; }
    public int ScreenId { get; set; }
    public Screen Screen { get; set; } = null!;
    public List<BookingSeatMapping> BookingSeats { get; set; } = new List<BookingSeatMapping>();
}
