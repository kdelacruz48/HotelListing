using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace HotelListing.Data
{
    public class DataBaseContext: DbContext
    {
        public DataBaseContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Hotel> Hotels { get; set; }

        protected override void OnModelCreating (ModelBuilder builder)
        {
            builder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "United States",
                    ShortName = "US"
                },
                new Country
                {
                    Id = 2,
                    Name = "Spain",
                    ShortName = "SP"
                },
                new Country
                {
                    Id = 3,
                    Name = "Japan",
                    ShortName = "JP"
                }
            );

            builder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "US Suites",
                    Address = "US",
                    CountryId = 1,
                    Rating = 4
                },
                new Hotel
                {
                    Id = 2,
                    Name = "Spain Suites",
                    Address = "SP",
                    CountryId = 2,
                    Rating = 5
                },
                new Hotel
                {
                    Id = 3,
                    Name = "Japan Suites",
                    Address = "JP",
                    CountryId = 3,
                    Rating = 5
                }
            );
        }
        
    }
}
