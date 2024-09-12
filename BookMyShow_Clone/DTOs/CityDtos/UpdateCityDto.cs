using System;
using BookMyShow_Clone.DTOs.Common;

namespace BookMyShow_Clone.DTOs.CityDtos;

public class UpdateCityDto : BaseDto
{
    public string Name { get; set; } = null!;
}
