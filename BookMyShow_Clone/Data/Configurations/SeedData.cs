using System;
using BookMyShow_Clone.Models;
using Microsoft.AspNetCore.Identity;

namespace BookMyShow_Clone.Data.Configurations;

public class SeedData
{
    private const int numMovies = 10;
    private const int numTheatres = 15;
    private const int numScreens = 30;
    private const int numSeatsPerScreen = 25;
    private const int showDays = 3;
    private const int numBookings = 18;
    private const int maxSeatsPerBooking = 5;
    TimeSpan[] showTimings =
    {
        new TimeSpan(14, 0, 0),
        new TimeSpan(17, 0, 0),
        new TimeSpan(20, 0, 0)
    };

    public Booking[] Bookings { get; set; } = null!;
    public Show[] Shows { get; set; } = null!;

    public Movie[] GenerateMovies()
    {
        var random = new Random();
        var movies = new Movie[numMovies];

        for (int i = 0; i < movies.Length; i++)
        {
            movies[i] = new Movie
            {
                Id = i + 1,
                Name = $"Movie {(char)('A' + i)}",
                ReleaseDate = new DateTime(2024, random.Next(1, 13), random.Next(1, 28)),
                IsShowingNow = random.Next(2) == 0, // Randomly sets to true or false
                DurationInSeconds = random.Next(90, 151) // Random duration between 90 and 150 minutes
            };
        }
        return movies;
    }

    public City[] Cities { get; set; } =
        {
            new City { Id = 1, Name = "New York" },
            new City { Id = 2, Name = "Los Angeles" },
            new City { Id = 3, Name = "Chicago" },
            new City { Id = 4, Name = "Houston" },
            new City { Id = 5, Name = "Philadelphia" }
        };

    public Theatre[] GenerateTheatres()
    {
        var random = new Random();
        var theatres = new Theatre[numTheatres];
        for (int i = 0; i < theatres.Length; i++)
        {
            theatres[i] = new Theatre
            {
                Id = i + 1,
                Name = $"Theatre {i + 1}",
                Location = $"Location {i + 1}",
                CityId = random.Next(1, Cities.Length + 1) // Randomly assigns a CityId between 1 and 5 inclusive
            };
        }
        return theatres;
    }

    public Screen[] GenerateScreens()
    {
        var random = new Random();
        var screens = new Screen[numScreens];
        for (int i = 0; i < screens.Length; i++)
        {
            screens[i] = new Screen
            {
                Id = i + 1,
                Name = $"Screen {i + 1}",
                TheatreId = random.Next(1, numTheatres + 1) // Randomly assigns a TheatreId between 1 and numTheatres
            };
        }
        return screens;
    }

    public Seat[] GenerateSeats()
    {
        var seats = new List<Seat>();
        int seatId = 1;

        for (int screenId = 1; screenId <= numScreens; screenId++)
        {
            for (int seatNum = 0; seatNum < numSeatsPerScreen; seatNum++)
            {
                seats.Add(
                    new Seat
                    {
                        Id = seatId++,
                        ScreenId = screenId,
                        RowNumber = (seatNum / 5) + 1, // 5 seats per row, giving 5 rows total per screen
                        SeatNumber = (seatNum % 5) + 1
                    }
                );
            }
        }

        return seats.ToArray();
    }

    public Show[] GenerateShows()
    {
        var random = new Random();
        var shows = new List<Show>();
        int showId = 1;

        // Define potential timings for shows (e.g., 14:00, 17:00, 20:00)

        // Generate shows for each screen
        for (int screenId = 1; screenId <= numScreens; screenId++)
        {
            // Generate shows over few days
            for (int dayOffset = 0; dayOffset < showDays; dayOffset++)
            {
                foreach (var time in showTimings)
                {
                    shows.Add(
                        new Show
                        {
                            Id = showId++,
                            Timing = new DateTime(2024, 11, 1).AddDays(dayOffset).Add(time),
                            ScreenId = screenId,
                            MovieId = random.Next(1, numMovies + 1) // Randomly assign a movie ID
                        }
                    );
                }
            }
        }
        Shows = shows.ToArray();
        return Shows;
    }

    public CityMovieMapping[] GenerateCityMovieMappings()
    {
        var random = new Random();
        var mappings = new List<CityMovieMapping>();
        int mappingId = 1;

        // Each city will be mapped to a few random movies
        for (int cityId = 1; cityId <= Cities.Length; cityId++)
        {
            // Determine the number of movies for each city (e.g., each city shows 2-4 movies)
            int moviesInCity = random.Next(2, 5); // Choose between 2 to 4 movies per city

            var selectedMovies = new HashSet<int>();
            for (int i = 0; i < moviesInCity; i++)
            {
                int movieId;
                do
                {
                    movieId = random.Next(1, numMovies + 1); // Get a random movie ID between 1 and numMovies
                } while (!selectedMovies.Add(movieId)); // Ensure each movie is mapped only once in a city

                mappings.Add(
                    new CityMovieMapping
                    {
                        Id = mappingId++,
                        CityId = cityId,
                        MovieId = movieId
                    }
                );
            }
        }

        return mappings.ToArray();
    }

    public MovieTheatreMapping[] GenerateMovieTheatreMappings()
    {
        var random = new Random();
        var mappings = new List<MovieTheatreMapping>();
        int mappingId = 1;

        // Each theatre will show a few random movies
        for (int theatreId = 1; theatreId <= numTheatres; theatreId++)
        {
            // Determine the number of movies for each theatre (e.g., each theatre shows 2-3 movies)
            int moviesInTheatre = random.Next(2, 4); // Choose between 2 to 3 movies per theatre

            var selectedMovies = new HashSet<int>();
            for (int i = 0; i < moviesInTheatre; i++)
            {
                int movieId;
                do
                {
                    movieId = random.Next(1, numMovies + 1); // Get a random movie ID between 1 and numMovies
                } while (!selectedMovies.Add(movieId)); // Ensure each movie is unique for the theatre

                mappings.Add(
                    new MovieTheatreMapping
                    {
                        Id = mappingId++,
                        MovieId = movieId,
                        TheatreId = theatreId
                    }
                );
            }
        }

        return mappings.ToArray();
    }

    public IdentityRole[] IdentityRoles { get; set; } =
        {
            new IdentityRole
            {
                Id = "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                Name = "User",
                NormalizedName = "USER"
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

    public Booking[] GenerateBookings()
    {
        var random = new Random();
        var userIds = new[]
        {
            "9e224968-33e4-4652-b7b7-8574d048cdb9", // Mayank Tolani
            "662ea775-6b80-49b3-9414-d03bcc043ec8", // Ameesh Singh
            "be15effc-7aaf-443c-8c02-f31d4eee3e96" // Prince Singh
        };

        var bookings = new Booking[numBookings];
        for (int i = 0; i < numBookings; i++)
        {
            bookings[i] = new Booking
            {
                Id = i + 1,
                ShowId = random.Next(1, Shows.Length + 1),
                UserId = userIds[random.Next(userIds.Length)]
            };
        }
        Bookings = bookings;
        return bookings;
    }

    public BookingSeatMapping[] GenerateBookingSeatMappings()
    {
        var random = new Random();
        var bookingSeatMappings = new List<BookingSeatMapping>();
        int idCounter = 1;

        foreach (var booking in Bookings)
        {
            // Find the ScreenId for the show associated with the booking
            var show = Shows.FirstOrDefault(s => s.Id == booking.ShowId);
            if (show == null)
                continue;

            // Calculate the seat range for the screen
            int startSeatId = (show.ScreenId - 1) * numSeatsPerScreen + 1;
            int endSeatId = startSeatId + numSeatsPerScreen - 1;

            // Determine the number of seats to book for this booking
            int seatsForThisBooking = random.Next(1, maxSeatsPerBooking + 1);

            var assignedSeats = new HashSet<int>();

            // Randomly select seats within the calculated range for this screen
            for (int i = 0; i < seatsForThisBooking; i++)
            {
                int seatId;
                do
                {
                    seatId = random.Next(startSeatId, endSeatId + 1);
                } while (!assignedSeats.Add(seatId)); // Ensure each seat is unique within the booking

                bookingSeatMappings.Add(
                    new BookingSeatMapping
                    {
                        Id = idCounter++,
                        BookingId = booking.Id,
                        SeatId = seatId
                    }
                );
            }
        }

        return bookingSeatMappings.ToArray();
    }
}
