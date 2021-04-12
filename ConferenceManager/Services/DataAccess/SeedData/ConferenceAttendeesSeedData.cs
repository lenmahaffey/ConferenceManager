using ConferenceManager.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConferenceManager.Services.DataAccess.SeedData
{
    public class ConferenceAttendeesSeedData : IEntityTypeConfiguration<ConferenceAttendee>
    {
        public void Configure(EntityTypeBuilder<ConferenceAttendee> builder)
        {
            builder.HasData(
                new ConferenceAttendee
                {
                    AttendeeID = 101,
                    ConferenceID = 1001
                },

                new ConferenceAttendee
                {
                    AttendeeID = 102,
                    ConferenceID = 1001
                },

                new ConferenceAttendee
                {
                    AttendeeID = 103,
                    ConferenceID = 1002
                },

                new ConferenceAttendee
                {
                    AttendeeID = 104,
                    ConferenceID = 1002
                },

                new ConferenceAttendee
                {
                    AttendeeID = 105,
                    ConferenceID = 1002
                },

                new ConferenceAttendee
                {
                    AttendeeID = 106,
                    ConferenceID = 1001
                });
        }
    }
}
