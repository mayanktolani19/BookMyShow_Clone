using System;
using BookMyShow_Clone.Models;
using Microsoft.AspNetCore.Identity;

namespace BookMyShow_Clone.Repository.Configurations;

public class SeedData
{
    public Movie[] Movies { get; set; } =
        {
            new Movie
            {
                Id = 1,
                Name = "Movie A",
                ReleaseDate = new DateTime(2024, 1, 1),
                IsShowingNow = true,
                DurationInSeconds = 120
            },
            new Movie
            {
                Id = 2,
                Name = "Movie B",
                ReleaseDate = new DateTime(2024, 2, 15),
                IsShowingNow = false,
                DurationInSeconds = 90
            },
            new Movie
            {
                Id = 3,
                Name = "Movie C",
                ReleaseDate = new DateTime(2024, 3, 20),
                IsShowingNow = true,
                DurationInSeconds = 150
            },
            new Movie
            {
                Id = 4,
                Name = "Movie D",
                ReleaseDate = new DateTime(2024, 4, 10),
                IsShowingNow = true,
                DurationInSeconds = 110
            },
            new Movie
            {
                Id = 5,
                Name = "Movie E",
                ReleaseDate = new DateTime(2024, 5, 5),
                IsShowingNow = false,
                DurationInSeconds = 95
            },
            new Movie
            {
                Id = 6,
                Name = "Movie F",
                ReleaseDate = new DateTime(2024, 6, 12),
                IsShowingNow = true,
                DurationInSeconds = 125
            },
            new Movie
            {
                Id = 7,
                Name = "Movie G",
                ReleaseDate = new DateTime(2024, 7, 18),
                IsShowingNow = false,
                DurationInSeconds = 100
            },
            new Movie
            {
                Id = 8,
                Name = "Movie H",
                ReleaseDate = new DateTime(2024, 8, 22),
                IsShowingNow = true,
                DurationInSeconds = 140
            },
            new Movie
            {
                Id = 9,
                Name = "Movie I",
                ReleaseDate = new DateTime(2024, 9, 30),
                IsShowingNow = true,
                DurationInSeconds = 115
            },
            new Movie
            {
                Id = 10,
                Name = "Movie J",
                ReleaseDate = new DateTime(2024, 10, 15),
                IsShowingNow = false,
                DurationInSeconds = 130
            }
        };

    public City[] Cities { get; set; } =
        {
            new City { Id = 1, Name = "New York" },
            new City { Id = 2, Name = "Los Angeles" },
            new City { Id = 3, Name = "Chicago" },
            new City { Id = 4, Name = "Houston" },
            new City { Id = 5, Name = "Philadelphia" }
        };

    public Theatre[] Theatres { get; set; } =
        {
            new Theatre
            {
                Id = 1,
                Name = "Theatre 1",
                Location = "Location 1",
                CityId = 1
            },
            new Theatre
            {
                Id = 2,
                Name = "Theatre 2",
                Location = "Location 2",
                CityId = 1
            },
            new Theatre
            {
                Id = 3,
                Name = "Theatre 3",
                Location = "Location 3",
                CityId = 2
            },
            new Theatre
            {
                Id = 4,
                Name = "Theatre 4",
                Location = "Location 4",
                CityId = 2
            },
            new Theatre
            {
                Id = 5,
                Name = "Theatre 5",
                Location = "Location 5",
                CityId = 3
            },
            new Theatre
            {
                Id = 6,
                Name = "Theatre 6",
                Location = "Location 6",
                CityId = 3
            },
            new Theatre
            {
                Id = 7,
                Name = "Theatre 7",
                Location = "Location 7",
                CityId = 4
            },
            new Theatre
            {
                Id = 8,
                Name = "Theatre 8",
                Location = "Location 8",
                CityId = 4
            },
            new Theatre
            {
                Id = 9,
                Name = "Theatre 9",
                Location = "Location 9",
                CityId = 5
            },
            new Theatre
            {
                Id = 10,
                Name = "Theatre 10",
                Location = "Location 10",
                CityId = 5
            },
            new Theatre
            {
                Id = 11,
                Name = "Theatre 11",
                Location = "Location 11",
                CityId = 5
            },
            new Theatre
            {
                Id = 12,
                Name = "Theatre 12",
                Location = "Location 12",
                CityId = 1
            },
            new Theatre
            {
                Id = 13,
                Name = "Theatre 13",
                Location = "Location 13",
                CityId = 2
            },
            new Theatre
            {
                Id = 14,
                Name = "Theatre 14",
                Location = "Location 14",
                CityId = 3
            },
            new Theatre
            {
                Id = 15,
                Name = "Theatre 15",
                Location = "Location 15",
                CityId = 4
            }
        };

    public Screen[] Screens { get; set; } =
        {
            new Screen
            {
                Id = 1,
                Name = "Screen 1",
                TheatreId = 1
            },
            new Screen
            {
                Id = 2,
                Name = "Screen 2",
                TheatreId = 1
            },
            new Screen
            {
                Id = 3,
                Name = "Screen 1",
                TheatreId = 2
            },
            new Screen
            {
                Id = 4,
                Name = "Screen 2",
                TheatreId = 2
            },
            new Screen
            {
                Id = 5,
                Name = "Screen 1",
                TheatreId = 3
            },
            new Screen
            {
                Id = 6,
                Name = "Screen 2",
                TheatreId = 3
            },
            new Screen
            {
                Id = 7,
                Name = "Screen 1",
                TheatreId = 4
            },
            new Screen
            {
                Id = 8,
                Name = "Screen 2",
                TheatreId = 4
            },
            new Screen
            {
                Id = 9,
                Name = "Screen 1",
                TheatreId = 5
            },
            new Screen
            {
                Id = 10,
                Name = "Screen 2",
                TheatreId = 5
            },
            new Screen
            {
                Id = 11,
                Name = "Screen 1",
                TheatreId = 6
            },
            new Screen
            {
                Id = 12,
                Name = "Screen 2",
                TheatreId = 6
            },
            new Screen
            {
                Id = 13,
                Name = "Screen 1",
                TheatreId = 7
            },
            new Screen
            {
                Id = 14,
                Name = "Screen 2",
                TheatreId = 7
            },
            new Screen
            {
                Id = 15,
                Name = "Screen 1",
                TheatreId = 8
            },
            new Screen
            {
                Id = 16,
                Name = "Screen 2",
                TheatreId = 8
            },
            new Screen
            {
                Id = 17,
                Name = "Screen 1",
                TheatreId = 9
            },
            new Screen
            {
                Id = 18,
                Name = "Screen 2",
                TheatreId = 9
            },
            new Screen
            {
                Id = 19,
                Name = "Screen 1",
                TheatreId = 10
            },
            new Screen
            {
                Id = 20,
                Name = "Screen 2",
                TheatreId = 10
            }
        };

    public Seat[] Seats { get; set; } =
        {
            new Seat
            {
                Id = 1,
                ScreenId = 1,
                SeatNumber = 1,
                RowNumber = 1
            },
            new Seat
            {
                Id = 1,
                ScreenId = 1,
                SeatNumber = 1,
                RowNumber = 1
            },
            new Seat
            {
                Id = 2,
                ScreenId = 1,
                SeatNumber = 2,
                RowNumber = 1
            },
            new Seat
            {
                Id = 3,
                ScreenId = 1,
                SeatNumber = 3,
                RowNumber = 1
            },
            new Seat
            {
                Id = 4,
                ScreenId = 1,
                SeatNumber = 4,
                RowNumber = 1
            },
            new Seat
            {
                Id = 5,
                ScreenId = 1,
                SeatNumber = 5,
                RowNumber = 1
            },
            new Seat
            {
                Id = 6,
                ScreenId = 1,
                SeatNumber = 1,
                RowNumber = 2
            },
            new Seat
            {
                Id = 7,
                ScreenId = 1,
                SeatNumber = 2,
                RowNumber = 2
            },
            new Seat
            {
                Id = 8,
                ScreenId = 1,
                SeatNumber = 3,
                RowNumber = 2
            },
            new Seat
            {
                Id = 9,
                ScreenId = 1,
                SeatNumber = 4,
                RowNumber = 2
            },
            new Seat
            {
                Id = 10,
                ScreenId = 1,
                SeatNumber = 5,
                RowNumber = 2
            },
            new Seat
            {
                Id = 11,
                ScreenId = 2,
                SeatNumber = 1,
                RowNumber = 1
            },
            new Seat
            {
                Id = 12,
                ScreenId = 2,
                SeatNumber = 2,
                RowNumber = 1
            },
            new Seat
            {
                Id = 13,
                ScreenId = 2,
                SeatNumber = 3,
                RowNumber = 1
            },
            new Seat
            {
                Id = 14,
                ScreenId = 2,
                SeatNumber = 4,
                RowNumber = 1
            },
            new Seat
            {
                Id = 15,
                ScreenId = 2,
                SeatNumber = 5,
                RowNumber = 1
            },
            new Seat
            {
                Id = 16,
                ScreenId = 2,
                SeatNumber = 1,
                RowNumber = 2
            },
            new Seat
            {
                Id = 17,
                ScreenId = 2,
                SeatNumber = 2,
                RowNumber = 2
            },
            new Seat
            {
                Id = 18,
                ScreenId = 2,
                SeatNumber = 3,
                RowNumber = 2
            },
            new Seat
            {
                Id = 19,
                ScreenId = 2,
                SeatNumber = 4,
                RowNumber = 2
            },
            new Seat
            {
                Id = 20,
                ScreenId = 2,
                SeatNumber = 5,
                RowNumber = 2
            },
            new Seat
            {
                Id = 21,
                ScreenId = 3,
                SeatNumber = 1,
                RowNumber = 1
            },
            new Seat
            {
                Id = 22,
                ScreenId = 3,
                SeatNumber = 2,
                RowNumber = 1
            },
            new Seat
            {
                Id = 23,
                ScreenId = 3,
                SeatNumber = 3,
                RowNumber = 1
            },
            new Seat
            {
                Id = 24,
                ScreenId = 3,
                SeatNumber = 4,
                RowNumber = 1
            },
            new Seat
            {
                Id = 25,
                ScreenId = 3,
                SeatNumber = 5,
                RowNumber = 1
            },
            new Seat
            {
                Id = 26,
                ScreenId = 3,
                SeatNumber = 1,
                RowNumber = 2
            },
            new Seat
            {
                Id = 27,
                ScreenId = 3,
                SeatNumber = 2,
                RowNumber = 2
            },
            new Seat
            {
                Id = 28,
                ScreenId = 3,
                SeatNumber = 3,
                RowNumber = 2
            },
            new Seat
            {
                Id = 29,
                ScreenId = 3,
                SeatNumber = 4,
                RowNumber = 2
            },
            new Seat
            {
                Id = 30,
                ScreenId = 3,
                SeatNumber = 5,
                RowNumber = 2
            }
        };

    public Show[] Shows { get; set; } =
        {
            new Show
            {
                Id = 1,
                Timing = new DateTime(2024, 9, 1, 14, 0, 0),
                ScreenId = 1,
                MovieId = 1
            },
            new Show
            {
                Id = 2,
                Timing = new DateTime(2024, 9, 1, 17, 0, 0),
                ScreenId = 2,
                MovieId = 2
            },
            new Show
            {
                Id = 3,
                Timing = new DateTime(2024, 9, 1, 20, 0, 0),
                ScreenId = 3,
                MovieId = 3
            },
            new Show
            {
                Id = 4,
                Timing = new DateTime(2024, 9, 2, 14, 0, 0),
                ScreenId = 4,
                MovieId = 4
            },
            new Show
            {
                Id = 5,
                Timing = new DateTime(2024, 9, 2, 17, 0, 0),
                ScreenId = 5,
                MovieId = 5
            },
            new Show
            {
                Id = 6,
                Timing = new DateTime(2024, 9, 2, 20, 0, 0),
                ScreenId = 6,
                MovieId = 6
            },
            new Show
            {
                Id = 7,
                Timing = new DateTime(2024, 9, 3, 14, 0, 0),
                ScreenId = 7,
                MovieId = 7
            },
            new Show
            {
                Id = 8,
                Timing = new DateTime(2024, 9, 3, 17, 0, 0),
                ScreenId = 8,
                MovieId = 8
            },
            new Show
            {
                Id = 9,
                Timing = new DateTime(2024, 9, 3, 20, 0, 0),
                ScreenId = 9,
                MovieId = 9
            },
            new Show
            {
                Id = 10,
                Timing = new DateTime(2024, 9, 4, 14, 0, 0),
                ScreenId = 10,
                MovieId = 10
            }
        };

    public CityMovieMapping[] CityMovieMappings { get; set; } =
        {
            new CityMovieMapping
            {
                Id = 1,
                CityId = 1,
                MovieId = 1
            },
            new CityMovieMapping
            {
                Id = 2,
                CityId = 1,
                MovieId = 2
            },
            new CityMovieMapping
            {
                Id = 3,
                CityId = 2,
                MovieId = 3
            },
            new CityMovieMapping
            {
                Id = 4,
                CityId = 2,
                MovieId = 4
            },
            new CityMovieMapping
            {
                Id = 5,
                CityId = 3,
                MovieId = 5
            },
            new CityMovieMapping
            {
                Id = 6,
                CityId = 3,
                MovieId = 6
            },
            new CityMovieMapping
            {
                Id = 7,
                CityId = 4,
                MovieId = 7
            },
            new CityMovieMapping
            {
                Id = 8,
                CityId = 4,
                MovieId = 8
            },
            new CityMovieMapping
            {
                Id = 9,
                CityId = 5,
                MovieId = 9
            },
            new CityMovieMapping
            {
                Id = 10,
                CityId = 5,
                MovieId = 10
            }
        };

    public MovieTheatreMapping[] MovieTheatreMappings { get; set; } =
        {
            new MovieTheatreMapping
            {
                Id = 1,
                MovieId = 1,
                TheatreId = 1
            },
            new MovieTheatreMapping
            {
                Id = 2,
                MovieId = 2,
                TheatreId = 1
            },
            new MovieTheatreMapping
            {
                Id = 3,
                MovieId = 3,
                TheatreId = 2
            },
            new MovieTheatreMapping
            {
                Id = 4,
                MovieId = 4,
                TheatreId = 3
            },
            new MovieTheatreMapping
            {
                Id = 5,
                MovieId = 5,
                TheatreId = 4
            },
            new MovieTheatreMapping
            {
                Id = 6,
                MovieId = 6,
                TheatreId = 5
            },
            new MovieTheatreMapping
            {
                Id = 7,
                MovieId = 7,
                TheatreId = 6
            },
            new MovieTheatreMapping
            {
                Id = 8,
                MovieId = 8,
                TheatreId = 7
            },
            new MovieTheatreMapping
            {
                Id = 9,
                MovieId = 9,
                TheatreId = 8
            },
            new MovieTheatreMapping
            {
                Id = 10,
                MovieId = 10,
                TheatreId = 9
            }
        };

    public IdentityRole[] IdentityRoles { get; set; } =
        {
            new IdentityRole
            {
                Id = "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                Name = "Employee",
                NormalizedName = "EMPLOYEE"
            },
            new IdentityRole
            {
                Id = "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                Name = "Administrator",
                NormalizedName = "ADMINISTRATOR"
            }
        };

    public User[] Users { get; set; } =
        {
            new User
            {
                Id = "8e445865-a24d-4543-a6c6-9443d048cdb9",
                Email = "admin@gmail.com",
                NormalizedEmail = "ADMIN@LOCALHOST.COM",
                FirstName = "System",
                LastName = "Admin",
                UserName = "admin@localhost.com",
                NormalizedUserName = "ADMIN@LOCALHOST.COM",
                PasswordHash = new PasswordHasher<User>().HashPassword(null!, "12345678"),
                EmailConfirmed = true
            },
            new User
            {
                Id = "9e224968-33e4-4652-b7b7-8574d048cdb9",
                Email = "mayank@gmail.com",
                NormalizedEmail = "MAYANK@GMAIL.COM",
                FirstName = "Mayank",
                LastName = "Tolani",
                UserName = "mayank@gmail.com",
                NormalizedUserName = "MAYANK@GMAIL.COM",
                PasswordHash = new PasswordHasher<User>().HashPassword(null!, "12345678"),
                EmailConfirmed = true
            },
            new User
            {
                Id = "662ea775-6b80-49b3-9414-d03bcc043ec8",
                Email = "ameesh@gmail.com",
                NormalizedEmail = "AMEESH@GMAIL.COM",
                FirstName = "Ameesh",
                LastName = "Singh",
                UserName = "ameesh@gmail.com",
                NormalizedUserName = "AMEESH@GMAIL.COM",
                PasswordHash = new PasswordHasher<User>().HashPassword(null!, "12345678"),
                EmailConfirmed = true
            },
            new User
            {
                Id = "be15effc-7aaf-443c-8c02-f31d4eee3e96",
                Email = "prince@gmail.com",
                NormalizedEmail = "PRINCE@GMAIL.COM",
                FirstName = "Prince",
                LastName = "Singh",
                UserName = "prince@gmail.com",
                NormalizedUserName = "PRINCE@GMAIL.COM",
                PasswordHash = new PasswordHasher<User>().HashPassword(null!, "12345678"),
                EmailConfirmed = true
            }
        };

    public Booking[] Bookings { get; set; } =
        {
            new Booking
            {
                Id = 1,
                ShowId = 1,
                UserId = "9e224968-33e4-4652-b7b7-8574d048cdb9"
            }, // Mayank Tolani
            new Booking
            {
                Id = 2,
                ShowId = 2,
                UserId = "662ea775-6b80-49b3-9414-d03bcc043ec8"
            }, // Ameesh Singh
            new Booking
            {
                Id = 3,
                ShowId = 3,
                UserId = "be15effc-7aaf-443c-8c02-f31d4eee3e96"
            }, // Prince Singh
            new Booking
            {
                Id = 4,
                ShowId = 1,
                UserId = "9e224968-33e4-4652-b7b7-8574d048cdb9"
            }, // Mayank Tolani
            new Booking
            {
                Id = 5,
                ShowId = 2,
                UserId = "662ea775-6b80-49b3-9414-d03bcc043ec8"
            }, // Ameesh Singh
            new Booking
            {
                Id = 6,
                ShowId = 3,
                UserId = "be15effc-7aaf-443c-8c02-f31d4eee3e96"
            }, // Prince Singh
            new Booking
            {
                Id = 7,
                ShowId = 4,
                UserId = "9e224968-33e4-4652-b7b7-8574d048cdb9"
            },
            new Booking
            {
                Id = 8,
                ShowId = 5,
                UserId = "662ea775-6b80-49b3-9414-d03bcc043ec8"
            },
            new Booking
            {
                Id = 9,
                ShowId = 6,
                UserId = "be15effc-7aaf-443c-8c02-f31d4eee3e96"
            },
            new Booking
            {
                Id = 10,
                ShowId = 7,
                UserId = "9e224968-33e4-4652-b7b7-8574d048cdb9"
            },
            new Booking
            {
                Id = 11,
                ShowId = 8,
                UserId = "662ea775-6b80-49b3-9414-d03bcc043ec8"
            },
            new Booking
            {
                Id = 12,
                ShowId = 9,
                UserId = "be15effc-7aaf-443c-8c02-f31d4eee3e96"
            },
            new Booking
            {
                Id = 13,
                ShowId = 10,
                UserId = "9e224968-33e4-4652-b7b7-8574d048cdb9"
            },
            new Booking
            {
                Id = 14,
                ShowId = 11,
                UserId = "662ea775-6b80-49b3-9414-d03bcc043ec8"
            },
            new Booking
            {
                Id = 15,
                ShowId = 12,
                UserId = "be15effc-7aaf-443c-8c02-f31d4eee3e96"
            },
            new Booking
            {
                Id = 16,
                ShowId = 13,
                UserId = "9e224968-33e4-4652-b7b7-8574d048cdb9"
            },
            new Booking
            {
                Id = 17,
                ShowId = 14,
                UserId = "662ea775-6b80-49b3-9414-d03bcc043ec8"
            },
            new Booking
            {
                Id = 18,
                ShowId = 15,
                UserId = "be15effc-7aaf-443c-8c02-f31d4eee3e96"
            },
            new Booking
            {
                Id = 19,
                ShowId = 16,
                UserId = "9e224968-33e4-4652-b7b7-8574d048cdb9"
            },
            new Booking
            {
                Id = 20,
                ShowId = 17,
                UserId = "662ea775-6b80-49b3-9414-d03bcc043ec8"
            },
            new Booking
            {
                Id = 21,
                ShowId = 18,
                UserId = "be15effc-7aaf-443c-8c02-f31d4eee3e96"
            },
            new Booking
            {
                Id = 22,
                ShowId = 19,
                UserId = "9e224968-33e4-4652-b7b7-8574d048cdb9"
            },
            new Booking
            {
                Id = 23,
                ShowId = 20,
                UserId = "662ea775-6b80-49b3-9414-d03bcc043ec8"
            },
            new Booking
            {
                Id = 24,
                ShowId = 21,
                UserId = "be15effc-7aaf-443c-8c02-f31d4eee3e96"
            },
            new Booking
            {
                Id = 25,
                ShowId = 22,
                UserId = "9e224968-33e4-4652-b7b7-8574d048cdb9"
            }
        };

    public BookingSeatMapping[] BookingSeatMappings { get; set; } =
        {
            new BookingSeatMapping
            {
                Id = 1,
                BookingId = 1,
                SeatId = 1
            },
            new BookingSeatMapping
            {
                Id = 2,
                BookingId = 2,
                SeatId = 2
            },
            new BookingSeatMapping
            {
                Id = 3,
                BookingId = 3,
                SeatId = 3
            },
            new BookingSeatMapping
            {
                Id = 4,
                BookingId = 4,
                SeatId = 4
            },
            new BookingSeatMapping
            {
                Id = 5,
                BookingId = 5,
                SeatId = 5
            },
            new BookingSeatMapping
            {
                Id = 6,
                BookingId = 6,
                SeatId = 6
            },
            new BookingSeatMapping
            {
                Id = 7,
                BookingId = 7,
                SeatId = 7
            },
            new BookingSeatMapping
            {
                Id = 8,
                BookingId = 8,
                SeatId = 8
            },
            new BookingSeatMapping
            {
                Id = 9,
                BookingId = 9,
                SeatId = 9
            },
            new BookingSeatMapping
            {
                Id = 10,
                BookingId = 10,
                SeatId = 10
            },
            new BookingSeatMapping
            {
                Id = 11,
                BookingId = 11,
                SeatId = 1
            },
            new BookingSeatMapping
            {
                Id = 12,
                BookingId = 12,
                SeatId = 2
            },
            new BookingSeatMapping
            {
                Id = 13,
                BookingId = 13,
                SeatId = 3
            },
            new BookingSeatMapping
            {
                Id = 14,
                BookingId = 14,
                SeatId = 4
            },
            new BookingSeatMapping
            {
                Id = 15,
                BookingId = 15,
                SeatId = 5
            },
            new BookingSeatMapping
            {
                Id = 16,
                BookingId = 16,
                SeatId = 6
            },
            new BookingSeatMapping
            {
                Id = 17,
                BookingId = 17,
                SeatId = 7
            },
            new BookingSeatMapping
            {
                Id = 18,
                BookingId = 18,
                SeatId = 8
            },
            new BookingSeatMapping
            {
                Id = 19,
                BookingId = 19,
                SeatId = 9
            },
            new BookingSeatMapping
            {
                Id = 20,
                BookingId = 20,
                SeatId = 10
            },
            new BookingSeatMapping
            {
                Id = 21,
                BookingId = 21,
                SeatId = 1
            },
            new BookingSeatMapping
            {
                Id = 22,
                BookingId = 22,
                SeatId = 2
            },
            new BookingSeatMapping
            {
                Id = 23,
                BookingId = 23,
                SeatId = 3
            },
            new BookingSeatMapping
            {
                Id = 24,
                BookingId = 24,
                SeatId = 4
            },
            new BookingSeatMapping
            {
                Id = 25,
                BookingId = 25,
                SeatId = 5
            },
        };
}
