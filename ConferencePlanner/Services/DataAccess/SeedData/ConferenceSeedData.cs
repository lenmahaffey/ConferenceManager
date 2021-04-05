using ConferenceManager.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace ConferenceManager.Models.DataAccess.SeedData
{
    public class ConferenceSeedData : IEntityTypeConfiguration<Conference>
    {
        public void Configure(EntityTypeBuilder<Conference> builder)
        {
            builder.HasData(
                new Conference
                {
                    ID = 1001,
                    Name = "International Association of National Associations",
                    Description = "The largest gathering of national association directors and managers in the world.",
                    StartDate = DateTime.Today,
                    EndDate = DateTime.Today.AddDays(4)
                },
                new Conference
                {
                    ID = 1002,
                    Name = "Acme Corp",
                    Description = "An exposition of the latest in roadrunner hunting equipment",
                    StartDate = DateTime.Today.AddDays(5),
                    EndDate = DateTime.Today.AddDays(9)
                });
        }
    }
}
