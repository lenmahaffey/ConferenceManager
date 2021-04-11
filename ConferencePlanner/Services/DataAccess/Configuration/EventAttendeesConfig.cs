using ConferenceManager.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConferenceManager.Services.DataAccess.Configuration
{
    public class EventAttendeesConfig : IEntityTypeConfiguration<EventAttendee>
    {
        public void Configure(EntityTypeBuilder<EventAttendee> builder)
        {
            builder.HasKey(ea => new { ea.EventID, ea.AttendeeID });

            builder.HasOne(ea => ea.Event)
                .WithMany(e => e.EventAttendees)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(ea => ea.Attendee)
                .WithMany(a => a.EventAttendees)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
