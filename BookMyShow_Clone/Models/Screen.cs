using System;
using System.ComponentModel.DataAnnotations;

namespace BookMyShow_Clone.Models;

public class Screen : BaseDomainEntity
{
    [Required]
    public string Name { get; set; } = "";

    [Required]
    public int TheatreId { get; set; }

    public Theatre Theatre { get; set; } = null!;
    public List<Seat> Seats { get; set; } = null!;
    public List<Show> Shows { get; set; } = null!;
}
