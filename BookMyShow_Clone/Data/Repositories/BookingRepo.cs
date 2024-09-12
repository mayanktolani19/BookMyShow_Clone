using System;
using BookMyShow_Clone.Contracts.Repositories;
using BookMyShow_Clone.Models;

namespace BookMyShow_Clone.Data.Repositories;

public class BookingRepo : GenericRepo<Booking>, IBookingRepo
{
    public BookingRepo(ApplicationDbContext dbContext)
        : base(dbContext) { }
}
