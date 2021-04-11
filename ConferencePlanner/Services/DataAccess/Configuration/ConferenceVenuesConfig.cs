using ConferenceManager.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConferenceManager.Services.DataAccess.Configuration
{
    public class ConferenceVenuesConfig : IEntityTypeConfiguration<ConferenceVenue>
    {
        public void Configure(EntityTypeBuilder<ConferenceVenue> builder)
        {
            builder.HasKey(cv => new { cv.ConferenceID, cv.VenueID });

            builder.HasOne(cv => cv.Conference)
                .WithMany(c => c.ConferenceVenues)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(cv => cv.Venue)
                .WithMany(v => v.ConferenceVenues)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
