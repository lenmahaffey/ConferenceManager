using ConferenceManager.Models.Entities;

namespace ConferenceManager.Services.DataAccess.Interfaces
{
    public interface IConferenceManagerUnit
    {
        ConferenceManagerRepository<Conference> Conferences { get; }
        ConferenceManagerRepository<Attendee> Attendees { get; }
        ConferenceManagerRepository<Venue> Venues { get; }
        ConferenceManagerRepository<Room> Rooms { get; }
        ConferenceManagerRepository<Presentation> Presentations { get; }
        void SaveChanges();
    }
}
