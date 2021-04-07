﻿using ConferenceManager.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConferenceManager.Services.DataAccess.Configurations
{
    public class ConferenceVenuesConfig : IEntityTypeConfiguration<ConferenceVenues>
    {
        public void Configure(EntityTypeBuilder<ConferenceVenues> builder)
        {
            builder.HasKey(cv => new { cv.ConferenceID, cv.VenueID });

            builder.HasOne(cv => cv.Conference)
                .WithMany(a => a.ConferenceVenues)
                .HasForeignKey(cv => cv.ConferenceID)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(cv => cv.Venue)
                .WithMany(a => a.ConferenceVenues)
                .HasForeignKey(cv => cv.VenueID)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}