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
    }
}
