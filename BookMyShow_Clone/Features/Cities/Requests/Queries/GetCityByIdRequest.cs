using System;
using BookMyShow_Clone.DTOs.CityDtos;
using FluentResults;
using MediatR;

namespace BookMyShow_Clone.Features.Cities.Requests.Queries;

public class GetCityByIdRequest : IRequest<Result<CityDto>>
{
    public int Id { get; set; }
}
