using ConferenceManager.Models.Entities;
using ConferenceManager.Services.DataAccess.Configuration;
using ConferenceManager.Services.DataAccess.SeedData;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ConferenceManager.Services.DataAccess
{
    public class ConferenceManagerContext : IdentityDbContext<User>
    {
        public ConferenceManagerContext(DbContextOptions<ConferenceManagerContext> options)
            : base(options)
        { }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Attendee> Attendees { get; set; }
        public DbSet<Attendee> Presenters { get; set; }
        public DbSet<Conference> Conferences { get; set; }
        public DbSet<ConferenceVenue> ConferenceVenues { get; set; }
        public DbSet<ConferenceAttendee> ConferenceAttendees { get; set; }
        public DbSet<EventAttendee> EventAttendees { get; set; }
        public DbSet<Presentation> Presentations { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Venue> Venues { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new ConferenceSeedData());
            modelBuilder.ApplyConfiguration(new AttendeeSeedData());
            modelBuilder.ApplyConfiguration(new PresenterSeedData());
            modelBuilder.ApplyConfiguration(new VenueSeedData());
            modelBuilder.ApplyConfiguration(new RoomSeedData());
            modelBuilder.ApplyConfiguration(new PresentationSeedData());


            modelBuilder.ApplyConfiguration(new ConferenceAttendeesSeedData());
            modelBuilder.ApplyConfiguration(new ConferenceVenuesSeedData());
            modelBuilder.ApplyConfiguration(new EventAttendeesSeedData());

            //ConferenceAttendee linking table
            modelBuilder.ApplyConfiguration(new ConferenceAttendeesConfig());

            //ConferenceVenue linking table
            modelBuilder.ApplyConfiguration(new ConferenceVenuesConfig());

            // PresentationAttendee linking table
            modelBuilder.ApplyConfiguration(new EventAttendeesConfig());

            modelBuilder.ApplyConfiguration(new EventConfig());

            modelBuilder.ApplyConfiguration(new RoomConfig());
        }
        public static async Task CreateAdminUser(IServiceProvider serviceProvider)
        {
            UserManager<User> userManager =
                serviceProvider.GetRequiredService<UserManager<User>>();
            RoleManager<IdentityRole> roleManager =
                serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();

            string username = "admin";
            string password = "P@ssw0rd";

            List<string> roles  = new List<string>{ "admin", "attendee", };
            foreach (var role in roles)
            {
                if (await roleManager.FindByNameAsync(role) == null)
                {
                    await roleManager.CreateAsync(new IdentityRole(role));
                }
            }
            if (await userManager.FindByNameAsync(username) == null)
            {
                User user = new User { UserName = username };
                var result = await userManager.CreateAsync(user, password);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, "admin");
                }
            }
        }
    }
}
