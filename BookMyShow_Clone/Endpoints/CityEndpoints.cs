using System;
using BookMyShow_Clone.DTOs;
using BookMyShow_Clone.DTOs.CityDtos;
using BookMyShow_Clone.Features.Cities.Requests.Commands;
using BookMyShow_Clone.Features.Cities.Requests.Queries;
using Carter;
using FluentResults;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BookMyShow_Clone.Endpoints;

public class CityEndpoints : CarterModule
{
    // private readonly IMediator _mediator;

    public CityEndpoints(IMediator mediator)
        : base("cities")
    {
        // _mediator = mediator;
    }

    public override void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapGet(
            "",
            async (IMediator mediator) =>
            {
                var cities = await mediator.Send(new GetCityListRequest());
                return Results.Ok(cities);
            }
        );

        app.MapGet(
            "/{id}",
            async (int id, IMediator mediator) =>
            {
                var result = await mediator.Send(new GetCityByIdRequest { Id = id });

                if (result.IsFailed)
                {
                    var errors = result.Errors.Select(e => e.Message).ToArray();
                    return Results.Json(new { errors }, statusCode: StatusCodes.Status404NotFound);
                }

                return Results.Ok(result.Value);
            }
        );

        app.MapPost(
            "",
            async ([FromBody] CreateCityDto createCityDto, IMediator mediator) =>
            {
                Result<CityDto> cityResult = await mediator.Send(
                    new CreateCityCommand { CreateCityDto = createCityDto }
                );
                return cityResult;
            }
        );

        app.MapPut(
            "",
            async ([FromBody] UpdateCityDto updateCityDto, IMediator mediator) =>
            {
                Result<CityDto> updateCityResult = await mediator.Send(
                    new UpdateCityCommand { UpdateCityDto = updateCityDto }
                );
                return updateCityResult;
            }
        );

        app.MapDelete(
            "{id}/{softDelete}",
            async (int id, bool softDelete, IMediator mediator) =>
            {
                Result<bool> deleteCityResult;
                if (softDelete)
                    deleteCityResult = await mediator.Send(new SoftDeleteCityCommand { Id = id });
                else
                    deleteCityResult = await mediator.Send(new DeleteCityCommand { Id = id });
                return deleteCityResult;
            }
        );
    }
}
