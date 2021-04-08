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
        private ConferenceManagerRepository<Conference> conferences;
        public ConferenceManagerRepository<Conference> Conferences
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
        private ConferenceManagerRepository<Attendee> attendees;
        public ConferenceManagerRepository<Attendee> Attendees
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
        private ConferenceManagerRepository<Venue> venues;
        public ConferenceManagerRepository<Venue> Venues
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
        private ConferenceManagerRepository<Room> rooms;
        public ConferenceManagerRepository<Room> Rooms
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
        private ConferenceManagerRepository<Presentation> presentations;
        public ConferenceManagerRepository<Presentation> Presentations
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
        private ConferenceManagerRepository<Event> events;
        public ConferenceManagerRepository<Event> Events
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
        private ConferenceManagerRepository<Contact> contacts;
        public ConferenceManagerRepository<Contact> Contacts
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
        public void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}
