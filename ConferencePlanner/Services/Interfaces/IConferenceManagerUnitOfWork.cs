using ConferenceManager.Models.Entities;

namespace ConferenceManager.Models.DataAccess
{
    interface IConferenceManagerUnitOfWork
    {
        ConferenceManagerRepository<Conference> Conferences { get; }
        ConferenceManagerRepository<Attendee> Attendees { get; }
        ConferenceManagerRepository<Venue> Venues { get; }
        ConferenceManagerRepository<Room> Rooms { get; }
        ConferenceManagerRepository<Presentation> Presentations { get; }
        void save();
    }
}
