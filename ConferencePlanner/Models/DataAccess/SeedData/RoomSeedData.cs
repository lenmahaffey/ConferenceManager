using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConferenceManager.Models.DataAccess.SeedData
{
    public class RoomSeedData : IEntityTypeConfiguration<Room>
    {
        public void Configure(EntityTypeBuilder<Room> builder)
        {
            builder.HasData(
                new Room
                {
                    RoomID = 1010,
                    VenueID = 10,
                    Name = "101",
                    TheatreCapacity = 100,
                    SchoolRoomCapacity = 50,
                    CrescentRoundCapacity = 65
                },
                new Room
                {
                    RoomID = 1011,
                    VenueID = 10,
                    Name = "201",
                    TheatreCapacity = 100,
                    SchoolRoomCapacity = 50,
                    CrescentRoundCapacity = 65
                },
                new Room
                {
                    RoomID = 1012,
                    VenueID = 10,
                    Name = "Mile High Ballroom",
                    TheatreCapacity = 1000,
                    SchoolRoomCapacity = 500,
                    CrescentRoundCapacity = 650
                },
                new Room
                {
                    RoomID = 1013,
                    VenueID = 11,
                    Name = "Marco Polo Ballroom",
                    TheatreCapacity = 500,
                    SchoolRoomCapacity = 250,
                    CrescentRoundCapacity = 350
                },
                new Room
                {
                    RoomID = 1014,
                    VenueID = 11,
                    Name = "Red Rover",
                    TheatreCapacity = 100,
                    SchoolRoomCapacity = 50,
                    CrescentRoundCapacity = 65
                });
        }
    }
}
