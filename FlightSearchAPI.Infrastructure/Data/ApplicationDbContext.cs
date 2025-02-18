using FlightSearchAPI.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FlightSearchAPI.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Flight> Flights { get; set; }
        public DbSet<SearchHistory> SearchHistories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Flight>()
                .HasKey(f => f.Id);

            modelBuilder.Entity<SearchHistory>()
                .HasKey(f => f.Id);

            // Create indexes for better search performance
            modelBuilder.Entity<Flight>()
                .HasIndex(f => new { f.Airline, f.Departure, f.Arrival })
                .HasDatabaseName("IX_Flight_Airline_Departure_Arrival");

            // Index for Price column to optimize searches based on price
            modelBuilder.Entity<Flight>()
                .HasIndex(f => f.Price)
                .HasDatabaseName("IX_Flight_Price");

            // Index for DepartureTime to optimize searches for flights by departure time
            modelBuilder.Entity<Flight>()
                .HasIndex(f => f.DepartureTime)
                .HasDatabaseName("IX_Flight_DepartureTime");

            // Seed flight data
            var airlines = new[] { "Fly Dubai", "Emirates", "Qatar Airways", "Singapore Airlines", "British Airways", "Air India" };
            var cities = new[] { "New York", "London", "Dubai", "Singapore", "Sydney", "Paris", "Tokyo", "Hong Kong", "Los Angeles", "Mumbai" };

            var flights = new List<Flight>();
            Random rand = new Random();

            for (int i = 1; i <= 1000; i++)
            {
                var departureCity = cities[rand.Next(cities.Length)];
                var arrivalCity = cities[rand.Next(cities.Length)];
                while (departureCity == arrivalCity)
                {
                    arrivalCity = cities[rand.Next(cities.Length)];
                }

                var departureTime = DateTime.Now.AddDays(rand.Next(1, 30)) + TimeSpan.FromHours(rand.Next(1, 24));
                var arrivalTime = departureTime.AddHours(rand.Next(6, 14));

                flights.Add(new Flight
                {
                    Id = i,
                    Airline = airlines[rand.Next(airlines.Length)],
                    Departure = departureCity,
                    Arrival = arrivalCity,
                    DepartureTime = departureTime,
                    ArrivalTime = arrivalTime,
                    Price = rand.Next(200, 1500)
                });
            }

            // Add seeded flight data to the Flights table
            modelBuilder.Entity<Flight>().HasData(flights);
        }
    }
}
