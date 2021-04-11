using ConferenceManager.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConferenceManager.Services.DataAccess.Configuration
{
    public class EventAttendeesConfig : IEntityTypeConfiguration<EventAttendees>
    {
        public void Configure(EntityTypeBuilder<EventAttendees> builder)
        {
            builder.HasKey(ea => new { ea.EventID, ea.AttendeeID });

            builder.HasOne(ea => ea.Event)
                .WithMany(e => e.EventAttendees)
                .HasForeignKey(ea => ea.EventID)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(ea => ea.Attendee)
                .WithMany(a => a.EventAttendees)
                .HasForeignKey(ea => ea.AttendeeID)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
