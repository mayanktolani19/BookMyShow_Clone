using System;
using AutoMapper;
using BookMyShow_Clone.Contracts.Repositories;
using BookMyShow_Clone.DTOs;
using BookMyShow_Clone.DTOs.CityDtos;
using BookMyShow_Clone.DTOs.CityDtos.Validators;
using BookMyShow_Clone.Errors;
using BookMyShow_Clone.Features.Cities.Requests.Commands;
using BookMyShow_Clone.Models;
using FluentResults;
using MediatR;

namespace BookMyShow_Clone.Features.Cities.Handlers.Commands;

public class UpdateCityCommandHandler : IRequestHandler<UpdateCityCommand, Result<CityDto>>
{
    private readonly ICityRepo _cityRepo;
    private readonly IMapper _mapper;

    public UpdateCityCommandHandler(ICityRepo cityRepo, IMapper mapper)
    {
        _cityRepo = cityRepo;
        _mapper = mapper;
    }

    public async Task<Result<CityDto>> Handle(
        UpdateCityCommand request,
        CancellationToken cancellationToken
    )
    {
        var validator = new UpdateCityDtoValidator();
        var validationResult = await validator.ValidateAsync(request.UpdateCityDto);

        if (validationResult.IsValid == false)
        {
            return new ValidationError(
                string.Join(';', validationResult.Errors.Select(x => x.ErrorMessage))
            );
        }

        City? city = await _cityRepo.GetAsync(request.UpdateCityDto.Id);

        if (city is null)
            return new RecordNotFoundError(
                $"City with id : {request.UpdateCityDto.Id} does not exists"
            );

        _mapper.Map(request.UpdateCityDto, city);
        _cityRepo.Update(city);
        await _cityRepo.Save();

        return Result.Ok(_mapper.Map<CityDto>(city));
    }
}
