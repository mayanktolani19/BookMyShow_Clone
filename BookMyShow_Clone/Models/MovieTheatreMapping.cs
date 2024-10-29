using System;

namespace BookMyShow_Clone.Models;

public class MovieTheatreMapping : BaseDomainEntity
{
    public int MovieId { get; set; }
    public Movie Movie { get; set; } = null!;
    public int TheatreId { get; set; }
    public Theatre Theatre { get; set; } = null!;
}
