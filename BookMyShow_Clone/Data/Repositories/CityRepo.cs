using System;
using BookMyShow_Clone.Contracts.Repositories;
using BookMyShow_Clone.Models;

namespace BookMyShow_Clone.Data.Repositories;

public class CityRepo : GenericRepo<City>, ICityRepo
{
    public CityRepo(ApplicationDbContext dbContext)
        : base(dbContext) { }
}
