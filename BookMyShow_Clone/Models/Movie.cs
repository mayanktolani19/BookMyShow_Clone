using System;
using System.ComponentModel.DataAnnotations;

namespace BookMyShow_Clone.Models;

public class Movie : BaseDomainEntity
{
    [Required]
    public string Name { get; set; } = "";

    [Required]
    public DateTime ReleaseDate { get; set; }

    [Required]
    public bool IsShowingNow { get; set; }

    [Required]
    public int DurationInSeconds { get; set; }

    public List<Show> Shows { get; set; } = new List<Show>();

    public List<CityMovieMapping> CityMovieMappings { get; set; } = new();
    public List<MovieTheatreMapping> MovieTheatreMappings { get; set; } = new();
}
