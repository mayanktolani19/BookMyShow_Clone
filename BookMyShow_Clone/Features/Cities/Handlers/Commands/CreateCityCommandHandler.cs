using System;
using AutoMapper;
using BookMyShow_Clone.Contracts.Repositories;
using BookMyShow_Clone.DTOs.CityDtos;
using BookMyShow_Clone.DTOs.CityDtos.Validators;
using BookMyShow_Clone.Errors;
using BookMyShow_Clone.Features.Cities.Requests.Commands;
using BookMyShow_Clone.Models;
using FluentResults;
using MediatR;

namespace BookMyShow_Clone.Features.Cities.Handlers.Commands;

public class CreateCityCommandHandler : IRequestHandler<CreateCityCommand, Result<CityDto>>
{
    private readonly ICityRepo _cityRepo;
    private readonly IMapper _mapper;

    public CreateCityCommandHandler(ICityRepo cityRepo, IMapper mapper)
    {
        _cityRepo = cityRepo;
        _mapper = mapper;
    }

    public async Task<Result<CityDto>> Handle(
        CreateCityCommand request,
        CancellationToken cancellationToken
    )
    {
        var validator = new CreateCityDtoValidator();
        var validationResult = await validator.ValidateAsync(request.CreateCityDto);

        if (validationResult.IsValid == false)
        {
            return new ValidationError(
                string.Join(';', validationResult.Errors.Select(x => x.ErrorMessage))
            );
        }
        City city = _mapper.Map<City>(request.CreateCityDto);
        city = await _cityRepo.CreateAsync(city);
        await _cityRepo.Save();
        return Result.Ok(_mapper.Map<CityDto>(city));
    }
}
