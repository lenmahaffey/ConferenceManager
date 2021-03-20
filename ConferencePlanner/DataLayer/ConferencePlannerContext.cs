using ConferencePlanner.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConferencePlanner.DataLayer
{
    public class ConferencePlannerContext : DbContext
    {
        public ConferencePlannerContext(DbContextOptions<ConferencePlannerContext> options)
            : base(options)
        {

        }

        public DbSet<Attendee> Attendees { get; set; }
        public DbSet<Conference> Conferences { get; set; }
        public DbSet<Presentation> Presentations { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Venue> Venue { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //ConferenceAttendee linking table
            modelBuilder.Entity<ConferenceAttendees>()
                .HasKey(ca => new { ca.ConferenceID, ca.AttendeeID });

            modelBuilder.Entity<ConferenceAttendees>()
                .HasOne(ca => ca.Conference)
                .WithMany(a => a.ConferenceAttendees)
                .HasForeignKey(ca => ca.ConferenceID);

            modelBuilder.Entity<ConferenceAttendees>()
                .HasOne(ca => ca.Attendee)
                .WithMany(a => a.ConferenceAttendees)
                .HasForeignKey(ca => ca.AttendeeID);

            // ConferenceVenue linking table
            modelBuilder.Entity<ConferenceVenues>()
                .HasKey(ca => new { ca.ConferenceID, ca.VenueID });

            modelBuilder.Entity<ConferenceVenues>()
                .HasOne(ca => ca.Conference)
                .WithMany(a => a.ConferenceVenues)
                .HasForeignKey(ca => ca.ConferenceID);

            modelBuilder.Entity<ConferenceVenues>()
                .HasOne(ca => ca.Venue)
                .WithMany(a => a.ConferenceVenues)
                .HasForeignKey(ca => ca.VenueID);

            // PresentationAttendee linking table
            modelBuilder.Entity<PresentationAttendees>()
                .HasKey(ca => new { ca.PresentationID, ca.AttendeeID });

            modelBuilder.Entity<PresentationAttendees>()
                .HasOne(ca => ca.Presentation)
                .WithMany(a => a.PresentationAttendees)
                .HasForeignKey(ca => ca.PresentationID);

            modelBuilder.Entity<PresentationAttendees>()
                .HasOne(ca => ca.Attendee)
                .WithMany(a => a.PresentationAttendees)
                .HasForeignKey(ca => ca.AttendeeID);
        }
    }
}
