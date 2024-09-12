using System;
using BookMyShow_Clone.Contracts.Repositories;
using BookMyShow_Clone.Models;

namespace BookMyShow_Clone.Data.Repositories;

public class MovieRepo : GenericRepo<Movie>, IMovieRepo
{
    public MovieRepo(ApplicationDbContext dbContext)
        : base(dbContext) { }
}
