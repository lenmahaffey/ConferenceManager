using ConferenceManager.Models.Entities;

namespace ConferenceManager.Services.DataAccess.Interfaces
{
    public interface IConferenceManagerUnit
    {
        IConferenceManagerRepository<Conference> Conferences { get; }
        IConferenceManagerRepository<Attendee> Attendees { get; }
        IConferenceManagerRepository<Venue> Venues { get; }
        IConferenceManagerRepository<Room> Rooms { get; }
        IConferenceManagerRepository<Presentation> Presentations { get; }
        IConferenceManagerRepository<ConferenceAttendee> ConferenceAttendees { get; }
        IConferenceManagerRepository<ConferenceVenue> ConferenceVenues { get; }
        IConferenceManagerRepository<EventAttendee> EventAttendees { get; }

        void SaveChanges();
    }
}
