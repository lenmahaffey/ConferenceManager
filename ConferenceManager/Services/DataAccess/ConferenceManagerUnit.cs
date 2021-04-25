using ConferenceManager.Models.Entities;
using ConferenceManager.Services.DataAccess.Interfaces;

namespace ConferenceManager.Services.DataAccess
{
    public class ConferenceManagerUnit : IConferenceManagerUnit
    {
        private ConferenceManagerContext context { get; set; }
        public ConferenceManagerUnit(ConferenceManagerContext ctx)
        {
            context = ctx;
        }
        private IConferenceManagerRepository<Conference> conferences;
        public IConferenceManagerRepository<Conference> Conferences
        {
            get
            {
                if(conferences == null)
                {
                    conferences = new ConferenceManagerRepository<Conference>(context);
                }
                return conferences;
            }
        }
        private IConferenceManagerRepository<Attendee> attendees;
        public IConferenceManagerRepository<Attendee> Attendees
        {
            get
            {
                if (attendees == null)
                {
                    attendees = new ConferenceManagerRepository<Attendee>(context);
                }
                return attendees;
            }
        }
        private IConferenceManagerRepository<Venue> venues;
        public IConferenceManagerRepository<Venue> Venues
        {
            get
            {
                if (venues == null)
                {
                    venues = new ConferenceManagerRepository<Venue>(context);
                }
                return venues;
            }
        }
        private IConferenceManagerRepository<Room> rooms;
        public IConferenceManagerRepository<Room> Rooms
        {
            get
            {
                if (rooms == null)
                {
                    rooms = new ConferenceManagerRepository<Room>(context);
                }
                return rooms;
            }
        }
        private IConferenceManagerRepository<Presentation> presentations;
        public IConferenceManagerRepository<Presentation> Presentations
        {
            get
            {
                if (presentations == null)
                {
                    presentations = new ConferenceManagerRepository<Presentation>(context);
                }
                return presentations;
            }
        }
        private IConferenceManagerRepository<Event> events;
        public IConferenceManagerRepository<Event> Events
        {
            get
            {
                if (events == null)
                {
                    events = new ConferenceManagerRepository<Event>(context);
                }
                return events;
            }
        }
        private IConferenceManagerRepository<Contact> contacts;
        public IConferenceManagerRepository<Contact> Contacts
        {
            get
            {
                if (contacts == null)
                {
                    contacts = new ConferenceManagerRepository<Contact>(context);
                }
                return contacts;
            }
        }
        private IConferenceManagerRepository<ConferenceAttendee> conferenceAttendees;
        public IConferenceManagerRepository<ConferenceAttendee> ConferenceAttendees
        {
            get
            {
                if (conferenceAttendees == null)
                {
                    conferenceAttendees = new ConferenceManagerRepository<ConferenceAttendee>(context);
                }
                return conferenceAttendees;
            }
        }
        private IConferenceManagerRepository<ConferenceVenue> conferenceVenues;
        public IConferenceManagerRepository<ConferenceVenue> ConferenceVenues
        {
            get
            {
                if (conferenceVenues == null)
                {
                    conferenceVenues = new ConferenceManagerRepository<ConferenceVenue>(context);
                }
                return conferenceVenues;
            }
        }
        private IConferenceManagerRepository<EventAttendee> eventAttendees;
        public IConferenceManagerRepository<EventAttendee> EventAttendees
        {
            get
            {
                if (eventAttendees == null)
                {
                    eventAttendees = new ConferenceManagerRepository<EventAttendee>(context);
                }
                return eventAttendees;
            }
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}
