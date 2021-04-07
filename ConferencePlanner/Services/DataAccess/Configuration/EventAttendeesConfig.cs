using ConferenceManager.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConferenceManager.Services.DataAccess.Configurations
{
    public class EventAttendeesConfig : IEntityTypeConfiguration<EventAttendees>
    {
        public void Configure(EntityTypeBuilder<EventAttendees> builder)
        {
            builder.HasKey(ea => new { ea.EventID, ea.AttendeeID });

            builder.HasOne(ea => ea.Event)
                .WithMany(a => a.EventAttendees)
                .HasForeignKey(ea => ea.EventID)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(pa => pa.Attendee)
                .WithMany(a => a.EventAttendees)
                .HasForeignKey(pa => pa.AttendeeID)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
