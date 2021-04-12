using ConferenceManager.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConferenceManager.Services.DataAccess.SeedData
{
    public class RoomSeedData : IEntityTypeConfiguration<Room>
    {
        public void Configure(EntityTypeBuilder<Room> builder)
        {
            builder.HasData(
                new Room
                {
                    ID = 1010,
                    VenueID = 10,
                    Name = "101",
                    TheatreCapacity = 100,
                    SchoolRoomCapacity = 50,
                    CrescentRoundCapacity = 65
                },
                new Room
                {
                    ID = 1011,
                    VenueID = 10,
                    Name = "201",
                    TheatreCapacity = 100,
                    SchoolRoomCapacity = 50,
                    CrescentRoundCapacity = 65
                },
                new Room
                {
                    ID = 1012,
                    VenueID = 10,
                    Name = "Mile High Ballroom",
                    TheatreCapacity = 1000,
                    SchoolRoomCapacity = 500,
                    CrescentRoundCapacity = 650
                },
                new Room
                {
                    ID = 1013,
                    VenueID = 11,
                    Name = "Marco Polo Ballroom",
                    TheatreCapacity = 500,
                    SchoolRoomCapacity = 250,
                    CrescentRoundCapacity = 350
                },
                new Room
                {
                    ID = 1014,
                    VenueID = 11,
                    Name = "Red Rover",
                    TheatreCapacity = 100,
                    SchoolRoomCapacity = 50,
                    CrescentRoundCapacity = 65
                });
        }
    }
}
