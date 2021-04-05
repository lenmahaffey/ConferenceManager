using ConferenceManager.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConferenceManager.DataLayer.Configurations
{
    public class ConferenceAttendeesConfig : IEntityTypeConfiguration<ConferenceAttendees>
    {
        public void Configure(EntityTypeBuilder<ConferenceAttendees> builder)
        {
            builder.HasKey(ca => new { ca.ConferenceID, ca.AttendeeID });

            builder.HasOne(ca => ca.Conference)
                .WithMany(a => a.ConferenceAttendees)
                .HasForeignKey(ca => ca.ConferenceID)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(ca => ca.Attendee)
                .WithMany(a => a.ConferenceAttendees)
                .HasForeignKey(ca => ca.AttendeeID)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
