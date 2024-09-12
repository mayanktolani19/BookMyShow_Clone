using System;
using BookMyShow_Clone.Contracts.Repositories;
using BookMyShow_Clone.Models;

namespace BookMyShow_Clone.Data.Repositories;

public class ScreenRepo : GenericRepo<Screen>, IScreenRepo
{
    public ScreenRepo(ApplicationDbContext dbContext)
        : base(dbContext) { }
}
