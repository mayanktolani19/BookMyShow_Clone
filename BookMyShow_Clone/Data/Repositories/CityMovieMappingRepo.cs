using System;
using BookMyShow_Clone.Contracts.Repositories;
using BookMyShow_Clone.Models;

namespace BookMyShow_Clone.Data.Repositories;

public class CityMovieMappingRepo : GenericRepo<CityMovieMapping>, ICityMovieMappingRepo
{
    public CityMovieMappingRepo(ApplicationDbContext dbContext)
        : base(dbContext) { }
}
