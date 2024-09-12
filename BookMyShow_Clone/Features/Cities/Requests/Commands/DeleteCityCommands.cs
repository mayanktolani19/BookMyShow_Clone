using System;
using FluentResults;
using MediatR;

namespace BookMyShow_Clone.Features.Cities.Requests.Commands;

public class SoftDeleteCityCommand : IRequest<Result<bool>>
{
    public int Id { get; set; }
}

public class DeleteCityCommand : IRequest<Result<bool>>
{
    public int Id { get; set; }
}
