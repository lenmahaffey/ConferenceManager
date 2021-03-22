using ConferenceManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConferenceManager.Services.Interfaces
{
    public interface IConferenceManagerData
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

        public void AddAttendee(Attendee attendee);
        public void AddConference(Conference conference);
        public void AddVenue(Venue venue);
        public void AddRoom(Room room);
        public void AddPresentation(Presentation presentation);

        public void EditAttendee(Attendee attendee);
        public void EditConference(Conference conference);
        public void EditVenue(Venue venue);
        public void EditRoom(Room Room);
        public void EditPresentation(Presentation presentation);
    }
}
