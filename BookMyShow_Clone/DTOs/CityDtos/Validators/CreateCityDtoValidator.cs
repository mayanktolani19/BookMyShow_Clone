using System;
using FluentValidation;

namespace BookMyShow_Clone.DTOs.CityDtos.Validators;

public class CreateCityDtoValidator : AbstractValidator<CreateCityDto>
{
    public CreateCityDtoValidator()
    {
        RuleFor(c => c.Name).NotEmpty().WithMessage("{PropertyName} is required.").NotNull();
    }
}
