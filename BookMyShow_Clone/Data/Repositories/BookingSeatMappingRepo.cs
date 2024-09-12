using System;
using BookMyShow_Clone.Contracts.Repositories;
using BookMyShow_Clone.Models;

namespace BookMyShow_Clone.Data.Repositories;

public class BookingSeatMappingRepo : GenericRepo<BookingSeatMapping>, IBookingSeatMappingRepo
{
    public BookingSeatMappingRepo(ApplicationDbContext dbContext)
        : base(dbContext) { }
}
