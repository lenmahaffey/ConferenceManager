using ConferenceManager.Models.Entities;
using ConferenceManager.Services.DataAccess.Configurations;
using ConferenceManager.Services.DataAccess.SeedData;
using Microsoft.EntityFrameworkCore;

namespace ConferenceManager.Services.DataAccess
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
        public DbSet<Venue> Venues { get; set; }
        public DbSet<Event> Events { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Room>()
                .HasOne(r => r.Venue)
                .WithMany(v => v.Rooms);

            modelBuilder.ApplyConfiguration(new AttendeeSeedData());
            modelBuilder.ApplyConfiguration(new ConferenceSeedData());
            modelBuilder.ApplyConfiguration(new VenueSeedData());
            modelBuilder.ApplyConfiguration(new RoomSeedData());
            modelBuilder.ApplyConfiguration(new PresentationSeedData());

            //ConferenceAttendee linking table
            modelBuilder.ApplyConfiguration(new ConferenceAttendeesConfig());

            //ConferenceVenue linking table
            modelBuilder.ApplyConfiguration(new ConferenceVenuesConfig());

            // PresentationAttendee linking table
            modelBuilder.ApplyConfiguration(new EventAttendeesConfig());
        }
    }
}
