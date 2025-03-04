using System;
using System.ComponentModel.DataAnnotations;

namespace BookMyShow_Clone.Models;

public class City : BaseDomainEntity
{
    [Required]
    public string Name { get; set; } = null!;
    public List<Theatre> Theatres { get; set; } = [];
    public List<CityMovieMapping> CityMovieMappings { get; set; } = [];
}
