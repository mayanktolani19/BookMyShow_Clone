using System;
using System.ComponentModel.DataAnnotations;

namespace BookMyShow_Clone.Models;

public class CityMovieMapping : BaseDomainEntity
{
    public int CityId { get; set; }
    public City City { get; set; } = null!;
    public int MovieId { get; set; }
    public Movie Movie { get; set; } = null!;
}
