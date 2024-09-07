using System;
using System.ComponentModel.DataAnnotations;

namespace BookMyShow_Clone.Models;

public class Theatre : BaseDomainEntity
{
    [Required]
    public string Name { get; set; } = "";

    [Required]
    public string Location { get; set; } = "";

    [Required]
    public int CityId { get; set; }
    public City City { get; set; } = null!;

    public List<Screen> Screens { get; set; } = null!;
    public List<MovieTheatreMapping> MovieTheatreMappings { get; set; } = new();
}
