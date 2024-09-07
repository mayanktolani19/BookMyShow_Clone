using System;
using Microsoft.AspNetCore.Identity;

namespace BookMyShow_Clone.Models;

public class User : IdentityUser
{
    public string FirstName { get; set; } = "";
    public string LastName { get; set; } = "";
    public List<Booking> Bookings { get; set; } = new List<Booking>();
}
