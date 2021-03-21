using ConferencePlanner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConferencePlanner.Services.Interfaces
{
    public interface IConferencePlannerData
    {
        IEnumerable<Attendee> GetAttendees();
        IEnumerable<Conference> GetConferences();
        IEnumerable<Presentation> GetPresentations();
        IEnumerable<Room> GetRooms();
        IEnumerable<Venue> GetVenues();

        Attendee GetAttendee(int id);
        Conference GetConference(int id);
        Presentation GetPresentation(int id);
        Room GetRoom(int id);
        Venue GetVenue(int id);

        void DeleteAttendee(Attendee attendee);

        void DeleteConference(Conference Conference);

        void DeletePresentation(Presentation Presentation);

        void DeleteVenue(Venue venue);

        void DeleteRoom(Room room);
    }
}
