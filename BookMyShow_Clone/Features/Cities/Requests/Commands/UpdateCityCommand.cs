using System;
using BookMyShow_Clone.DTOs.CityDtos;
using FluentResults;
using MediatR;

namespace BookMyShow_Clone.Features.Cities.Requests.Commands;

public class UpdateCityCommand : IRequest<Result<CityDto>>
{
    public UpdateCityDto UpdateCityDto { get; set; } = null!;
}
