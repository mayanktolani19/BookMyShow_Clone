using System;
using BookMyShow_Clone.DTOs.CityDtos;
using FluentResults;
using MediatR;

namespace BookMyShow_Clone.Features.Cities.Requests.Commands;

public class CreateCityCommand : IRequest<Result<CityDto>>
{
    public CreateCityDto CreateCityDto { get; set; } = null!;
}
