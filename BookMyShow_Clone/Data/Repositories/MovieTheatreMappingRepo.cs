using System;
using BookMyShow_Clone.Contracts.Repositories;
using BookMyShow_Clone.Models;

namespace BookMyShow_Clone.Data.Repositories;

public class MovieTheatreMappingRepo : GenericRepo<MovieTheatreMapping>, IMovieTheatreMappingRepo
{
    public MovieTheatreMappingRepo(ApplicationDbContext dbContext)
        : base(dbContext) { }
}
