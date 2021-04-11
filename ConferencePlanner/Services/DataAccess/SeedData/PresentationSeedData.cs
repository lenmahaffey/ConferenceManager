using ConferenceManager.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace ConferenceManager.Services.DataAccess.SeedData
{
    public class PresentationSeedData : IEntityTypeConfiguration<Presentation>
    {
        public void Configure(EntityTypeBuilder<Presentation> builder)
        {
            builder.HasData(
                new Presentation
                {
                    ID = 101,
                    ConferenceID = 1001,
                    PresenterID = 102,
                    RoomID = 1010,
                    Name = "Professional Associations in the 21st century",
                    Description = "Hear our president discuss the role of professional organizations in the 21st century",
                    StartTime = DateTime.Now.AddDays(1),
                    EndTime = DateTime.Now.AddHours(2).AddDays(1)
                },
                new Presentation
                {
                    ID = 102,
                    ConferenceID = 1001,
                    PresenterID = 101,
                    RoomID = 1011,
                    Name = "Member Services",
                    Description = "Join a discussion about the various services a professional organization can offer it's members",
                    StartTime = DateTime.Now.AddDays(2),
                    EndTime = DateTime.Now.AddHours(2).AddDays(2)
                },
                new Presentation
                {
                    ID = 103,
                    ConferenceID = 1002,
                    PresenterID = 104,
                    RoomID = 1011,
                    Name = "Paint Application in Aird Climates",
                    Description = "Learn about the proper application of our tunnel paint in dry arid climates.",
                    StartTime = DateTime.Now.AddDays(2),
                    EndTime = DateTime.Now.AddHours(2).AddDays(2)
                },
                new Presentation
                {
                    ID = 104,
                    ConferenceID = 1002,
                    PresenterID = 105,
                    RoomID = 1013,
                    Name = "Acme Orbital",
                    Description = "Our rockets aren't just for hunting! Come hear about Acme's plans to land the first coyote on the moon",
                    StartTime = DateTime.Now.AddDays(2),
                    EndTime = DateTime.Now.AddHours(2).AddDays(2)
                });
        }
    }
}
