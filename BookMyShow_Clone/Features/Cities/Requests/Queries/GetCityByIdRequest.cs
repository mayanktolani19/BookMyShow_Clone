using System;
using BookMyShow_Clone.DTOs.CityDtos;
using MediatR;

namespace BookMyShow_Clone.Features.Cities.Requests.Queries;

public class GetCityByIdRequest : IRequest<CityDto>
{
    public int Id { get; set; }
}
