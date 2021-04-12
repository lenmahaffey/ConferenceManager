using ConferenceManager.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConferenceManager.Services.DataAccess.SeedData
{
    public class EventAttendeesSeedData : IEntityTypeConfiguration<EventAttendee>
    {
        public void Configure(EntityTypeBuilder<EventAttendee> builder)
        {
            builder.HasData(
                new EventAttendee
                {
                    AttendeeID = 101,
                    EventID = 101
                },
                new EventAttendee
                {
                    AttendeeID = 102,
                    EventID = 102
                },
                new EventAttendee
                {
                    AttendeeID = 103,
                    EventID = 103
                },
                new EventAttendee
                {
                    AttendeeID = 104,
                    EventID = 101
                },
                new EventAttendee
                {
                    AttendeeID = 104,
                    EventID = 102
                });
        }
    }
}
