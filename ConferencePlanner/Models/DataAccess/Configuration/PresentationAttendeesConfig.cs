using ConferenceManager.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConferenceManager.DataLayer.Configurations
{
    public class PresentationAttendeesConfig : IEntityTypeConfiguration<EventAttendees>
    {
        public void Configure(EntityTypeBuilder<EventAttendees> builder)
        {
            builder.HasKey(pa => new { pa.PresentationID, pa.AttendeeID });

            builder.HasOne(pa => pa.Presentation)
                .WithMany(a => a.EventAttendees)
                .HasForeignKey(pa => pa.PresentationID)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(pa => pa.Attendee)
                .WithMany(a => a.EventAttendees)
                .HasForeignKey(pa => pa.AttendeeID)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
