using System;
using BookMyShow_Clone.Data.Configurations;
using BookMyShow_Clone.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BookMyShow_Clone.Data;

public class ApplicationDbContext : IdentityDbContext<User>
{
    public DbSet<Movie> Movies { get; set; }
    public DbSet<City> Cities { get; set; }
    public DbSet<Theatre> Theatres { get; set; }
    public DbSet<Screen> Screens { get; set; }
    public DbSet<Show> Shows { get; set; }
    public DbSet<Seat> Seats { get; set; }
    public DbSet<Booking> Bookings { get; set; }
    public DbSet<BookingSeatMapping> BookingSeatMappings { get; set; }

    public DbSet<CityMovieMapping> CityMovieMappings { get; set; }
    public DbSet<MovieTheatreMapping> MovieTheatreMappings { get; set; }

    public ApplicationDbContext(DbContextOptions dbContextOptions)
        : base(dbContextOptions) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        SeedData seedData = new SeedData();

        // BookingSeatMapping relationships
        modelBuilder
            .Entity<BookingSeatMapping>()
            .HasOne(bsm => bsm.Booking)
            .WithMany(b => b.BookingSeats)
            .HasForeignKey(bsm => bsm.BookingId)
            .OnDelete(DeleteBehavior.Restrict); // Disable cascading deletes here

        modelBuilder
            .Entity<BookingSeatMapping>()
            .HasOne(bsm => bsm.Seat)
            .WithMany(s => s.BookingSeats)
            .HasForeignKey(bsm => bsm.SeatId)
            .OnDelete(DeleteBehavior.Restrict); // Disable cascading deletes here

        // Check other relationships involving Booking and Seat
        modelBuilder
            .Entity<Booking>()
            .HasMany(b => b.BookingSeats)
            .WithOne(bsm => bsm.Booking)
            .OnDelete(DeleteBehavior.Restrict); // Disable cascading deletes here

        modelBuilder
            .Entity<Seat>()
            .HasMany(s => s.BookingSeats)
            .WithOne(bsm => bsm.Seat)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<City>().HasData(seedData.Cities);
        modelBuilder.Entity<Movie>().HasData(seedData.GenerateMovies());
        modelBuilder.Entity<Theatre>().HasData(seedData.GenerateTheatres());
        modelBuilder.Entity<Screen>().HasData(seedData.GenerateScreens());
        modelBuilder.Entity<Seat>().HasData(seedData.GenerateSeats());
        modelBuilder.Entity<Show>().HasData(seedData.GenerateShows());
        modelBuilder.Entity<CityMovieMapping>().HasData(seedData.GenerateCityMovieMappings());
        modelBuilder.Entity<IdentityRole>().HasData(seedData.IdentityRoles);
        modelBuilder.Entity<User>().HasData(seedData.Users);
        modelBuilder.Entity<Booking>().HasData(seedData.GenerateBookings());
        modelBuilder.Entity<BookingSeatMapping>().HasData(seedData.GenerateBookingSeatMappings());
        modelBuilder.Entity<MovieTheatreMapping>().HasData(seedData.GenerateMovieTheatreMappings());
    }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        foreach (var entry in ChangeTracker.Entries<BaseDomainEntity>())
        {
            entry.Entity.LastModifiedDate = DateTime.Now;

            if (entry.State == EntityState.Added)
            {
                entry.Entity.DateCreated = DateTime.Now;
            }
        }
        return base.SaveChangesAsync(cancellationToken);
    }
}
