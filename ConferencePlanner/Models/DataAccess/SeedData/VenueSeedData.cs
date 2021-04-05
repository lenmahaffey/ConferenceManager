﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConferenceManager.Models.DataAccess.SeedData
{
    public class VenueSeedData : IEntityTypeConfiguration<Venue>
    {
        public void Configure(EntityTypeBuilder<Venue> builder)
        {
            builder.HasData(
                new Venue
                {
                    VenueID = 10,
                    Name = "Colorado Convention Center",
                    Address1 = "700 14th St",
                    City = "Denver",
                    State = "CO",
                    PostalCode = "80202",
                    Phone = "303-303-0000"
                },
                new Venue
                {
                    VenueID = 11,
                    Name = "The Curtis Hotel",
                    Address1 = "1405 Curtis St",
                    City = "Denver",
                    State = "CO",
                    PostalCode = "80202",
                    Phone = "720-303-0000"
                });
        }
    }
}
