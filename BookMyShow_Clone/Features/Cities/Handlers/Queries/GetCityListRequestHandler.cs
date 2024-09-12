using System;
using AutoMapper;
using BookMyShow_Clone.Contracts.Repositories;
using BookMyShow_Clone.DTOs.CityDtos;
using BookMyShow_Clone.Features.Cities.Requests.Queries;
using MediatR;

namespace BookMyShow_Clone.Features.Cities.Handlers.Queries;

public class GetCityListRequestHandler : IRequestHandler<GetCityListRequest, List<CityDto>>
{
    private readonly ICityRepo _cityRepo;
    private readonly IMapper _mapper;

    public GetCityListRequestHandler(ICityRepo cityRepo, IMapper mapper)
    {
        _cityRepo = cityRepo;
        _mapper = mapper;
    }

    public async Task<List<CityDto>> Handle(
        GetCityListRequest request,
        CancellationToken cancellationToken
    )
    {
        var cities = await _cityRepo.GetAllAsync();
        return _mapper.Map<List<CityDto>>(cities);
    }
}
