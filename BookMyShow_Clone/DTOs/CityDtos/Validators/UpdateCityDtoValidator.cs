using System;
using FluentValidation;

namespace BookMyShow_Clone.DTOs.CityDtos.Validators;

public class UpdateCityDtoValidator : AbstractValidator<UpdateCityDto>
{
    public UpdateCityDtoValidator()
    {
        RuleFor(c => c.Id).NotEmpty().WithMessage("{PropertyName} is required.").NotNull();
        RuleFor(c => c.Name).NotEmpty().WithMessage("{PropertyName} is required.").NotNull();
    }
}
