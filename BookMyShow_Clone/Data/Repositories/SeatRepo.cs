using System;
using BookMyShow_Clone.Contracts.Repositories;
using BookMyShow_Clone.Models;

namespace BookMyShow_Clone.Data.Repositories;

public class SeatRepo : GenericRepo<Seat>, ISeatRepo
{
    public SeatRepo(ApplicationDbContext dbContext)
        : base(dbContext) { }
}
