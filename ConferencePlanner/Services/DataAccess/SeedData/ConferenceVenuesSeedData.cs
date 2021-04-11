using ConferenceManager.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConferenceManager.Services.DataAccess.SeedData
{
    public class ConferenceVenuesSeedData : IEntityTypeConfiguration<ConferenceVenue>
    {
        public void Configure(EntityTypeBuilder<ConferenceVenue> builder)
        {
            builder.HasData(
                new ConferenceVenue
                {
                    ConferenceID = 1001,
                    VenueID = 10
                },
                new ConferenceVenue
                {
                    ConferenceID = 1002,
                    VenueID = 11
                });
        }
    }
}
