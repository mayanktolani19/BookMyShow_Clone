using System;
using BookMyShow_Clone.Contracts.Repositories;
using BookMyShow_Clone.Models;

namespace BookMyShow_Clone.Data.Repositories;

public class TheatreRepo : GenericRepo<Theatre>, ITheatreRepo
{
    public TheatreRepo(ApplicationDbContext dbContext)
        : base(dbContext) { }
}
