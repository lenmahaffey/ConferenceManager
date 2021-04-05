using ConferenceManager.DataLayer.Configurations;
using ConferenceManager.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace ConferenceManager.DataLayer
{
    public class ConferenceManagerContext : DbContext
    {
        public ConferenceManagerContext(DbContextOptions<ConferenceManagerContext> options)
            : base(options)
        { }
        public DbSet<Attendee> Attendees { get; set; }
        public DbSet<Conference> Conferences { get; set; }
        public DbSet<Presentation> Presentations { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Venue> Venue { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //ConferenceAttendee linking table
            modelBuilder.ApplyConfiguration(new ConferenceAttendeesConfig());

            //ConferenceVenue linking table
            modelBuilder.ApplyConfiguration(new ConferenceVenuesConfig());

            // PresentationAttendee linking table
            modelBuilder.ApplyConfiguration(new PresentationAttendeesConfig());
        }
    }
}
