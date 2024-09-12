using System;
using BookMyShow_Clone.Contracts.Repositories;
using BookMyShow_Clone.Models;

namespace BookMyShow_Clone.Data.Repositories;

public class ShowRepo : GenericRepo<Show>, IShowRepo
{
    public ShowRepo(ApplicationDbContext dbContext)
        : base(dbContext) { }
}
