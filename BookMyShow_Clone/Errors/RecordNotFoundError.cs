using System;
using FluentResults;

namespace BookMyShow_Clone.Errors;

public class RecordNotFoundError : Error
{
    public RecordNotFoundError(string message)
        : base(message) { }
}
