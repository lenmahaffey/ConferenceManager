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

        IEnumerable<Attendee> GetAllAttendeesForConference(int conferenceID);
        IEnumerable<Attendee> GetAllAttendeesForPresentation(int presentationID);
        IEnumerable<Attendee> GetAllPresentationsForAttendee(int attendeeID);
        IEnumerable<Attendee> GetAllConferencesForAttendee(int attendeeID);
        IEnumerable<Venue> GetAllVenuesForConference(int conferenceID);
        IEnumerable<Venue> GetAllConferencesForVenue(int venueID);
        IEnumerable<Room> GetAllRoomsForVenue(int venueID);

        void AddAttendee(Attendee attendee);
        void EditAttendee(Attendee attendee);
        void DeleteAttendee(Attendee attendee);

        void AddConference(Conference Conference);
        void EditConference(Conference Conference);
        void DeleteConference(Conference Conference);

        void AddPresentation(Presentation Presentation);
        void EditPresentation(Presentation Presentation);
        void DeletePresentation(Presentation Presentation);

        void AddRooms(Room Rooms);
        void EditRooms(Room Rooms);
        void DeleteRooms(Room Rooms);

        void AddVenue(Venue Venue);
        void EditVenue(Venue Venue);
        void DeleteVenue(Venue Venue);

        void AddAttendeeToConference(Conference conference, Attendee attendee);
        void RemoveAttendeeFromConference(Conference conference, Attendee attendee);
        void AddVenueToConference(Conference conference, Attendee attendee);
        void RemoveVenueFromConference(Conference conference, Attendee attendee);
        void AddAttendeeToPresentation(Presentation presentation, Attendee attendee);
        void RemoveAttendeeFromPresentation(Presentation presentation, Attendee attendee);
    }
}
