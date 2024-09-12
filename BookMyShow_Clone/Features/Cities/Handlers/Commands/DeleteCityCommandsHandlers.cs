using System;
using AutoMapper;
using BookMyShow_Clone.Contracts.Repositories;
using BookMyShow_Clone.Errors;
using BookMyShow_Clone.Features.Cities.Requests.Commands;
using BookMyShow_Clone.Models;
using FluentResults;
using MediatR;

namespace BookMyShow_Clone.Features.Cities.Handlers.Commands;

public class DeleteCityCommandHandler : IRequestHandler<DeleteCityCommand, Result<bool>>
{
    private readonly ICityRepo _cityRepo;
    private readonly IMapper _mapper;

    public DeleteCityCommandHandler(ICityRepo cityRepo, IMapper mapper)
    {
        _cityRepo = cityRepo;
        _mapper = mapper;
    }

    public async Task<Result<bool>> Handle(
        DeleteCityCommand request,
        CancellationToken cancellationToken
    )
    {
        City? city = await _cityRepo.GetAsync(request.Id);
        if (city is null)
        {
            return new RecordNotFoundError($"City with id : {request.Id} does not exists");
        }
        _cityRepo.Delete(city);
        await _cityRepo.Save();
        return Result.Ok(true);
    }
}

public class SoftDeleteCityCommandHandler : IRequestHandler<SoftDeleteCityCommand, Result<bool>>
{
    private readonly ICityRepo _cityRepo;
    private readonly IMapper _mapper;

    public SoftDeleteCityCommandHandler(ICityRepo cityRepo, IMapper mapper)
    {
        _cityRepo = cityRepo;
        _mapper = mapper;
    }

    public async Task<Result<bool>> Handle(
        SoftDeleteCityCommand request,
        CancellationToken cancellationToken
    )
    {
        City? city = await _cityRepo.GetAsync(request.Id);
        if (city is null)
        {
            return new RecordNotFoundError($"City with id : {request.Id} does not exists");
        }
        _cityRepo.SoftDelete(city);
        await _cityRepo.Save();
        return Result.Ok(true);
    }
}
