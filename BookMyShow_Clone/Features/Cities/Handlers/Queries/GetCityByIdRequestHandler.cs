using System;
using AutoMapper;
using BookMyShow_Clone.Contracts.Repositories;
using BookMyShow_Clone.DTOs.CityDtos;
using BookMyShow_Clone.Features.Cities.Requests.Queries;
using BookMyShow_Clone.Models;
using MediatR;

namespace BookMyShow_Clone.Features.Cities.Handlers.Queries;

public class GetCityByIdRequestHandler : IRequestHandler<GetCityByIdRequest, CityDto>
{
    private readonly ICityRepo _cityRepo;
    private readonly IMapper _mapper;

    public GetCityByIdRequestHandler(ICityRepo cityRepo, IMapper mapper)
    {
        _cityRepo = cityRepo;
        _mapper = mapper;
    }

    public async Task<CityDto> Handle(
        GetCityByIdRequest request,
        CancellationToken cancellationToken
    )
    {
        City? city = await _cityRepo.GetAsync(request.Id);
        return _mapper.Map<CityDto>(city);
    }
}
