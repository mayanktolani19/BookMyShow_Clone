using System;
using System.ComponentModel.DataAnnotations;
using BookMyShow_Clone.DTOs.Common;

namespace BookMyShow_Clone.DTOs.CityDtos;

public class CityDto : BaseDto
{
    [Required]
    public string Name { get; set; } = null!;
}
