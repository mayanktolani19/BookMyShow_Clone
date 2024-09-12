using System;
using FluentResults;

namespace BookMyShow_Clone.Errors;

public class ValidationError : Error
{
    public ValidationError(string message)
        : base(message) { }
}
