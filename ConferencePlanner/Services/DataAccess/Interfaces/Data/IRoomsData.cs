using ConferenceManager.Models.Entities;
using System.Collections.Generic;

namespace ConferenceManager.Services.Interfaces
{
    interface IRoomsData
    {
        Room GetRoom(int id);
        IEnumerable<Room> GetRooms();
        void DeleteRoom(Room room);
        public void AddRoom(Room room);
        public void EditRoom(Room Room);
    }
}
