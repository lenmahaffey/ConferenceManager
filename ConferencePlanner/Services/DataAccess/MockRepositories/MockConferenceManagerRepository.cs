using ConferenceManager.Models.Entities;
using ConferenceManager.Services.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConferenceManager.Services.DataAccess.MockRepositories
{
    public class MockConferenceManagerRepository<T> : IConferenceManagerRepository<T> where T : class
    {
        private List<Attendee> attendees;
        private List<Presentation> presentations;
        private List<Room> rooms;
        private List<Venue> venues;
        private List<ConferenceAttendees> conferenceAttendees;
        private List<ConferenceVenues> conferenceVenues;
        private List<EventAttendees> eventAttendees;
        public MockConferenceManagerRepository()
        {
            if (attendees == null)
            {
                InitializeAttendees();
            }

            if (presentations == null)
            {
                InitalizePresentations();
            }
            if (rooms == null)
            {
                InitalizeRooms();
            }
            if (venues == null)
            {
                InitalizeVenues();
            }

            if (conferenceAttendees == null)
            {
                InitalizeConferenceAttendees();
            }
            if (conferenceVenues == null)
            {
                InitalizeConferenceVenues();
            }
            if (eventAttendees == null)
            {
                InitalizeEventAttendees();
            }

        }

        private void InitializeAttendees()
        {
            attendees = new List<Attendee>()
            {
                new Attendee
                {
                    ID = 101,
                    FirstName = "Steve",
                    LastName = "Johnson",
                    Phone = "303-303-3030",
                    Email = "steve@juno.com",
                    IsPresenter = true,
                    IsStaff = false,
                    DateRegistered = DateTime.Today
                },
                new Attendee
                {
                    ID = 102,
                    FirstName = "Dave",
                    LastName = "Jackson",
                    Phone = "303-303-3031",
                    Email = "dave@juno.com",
                    IsPresenter = true,
                    IsStaff = false,
                    DateRegistered = DateTime.Today
                },
                new Attendee
                {
                    ID = 103,
                    FirstName = "Cherrith",
                    LastName = "Goodstory",
                    Phone = "303-303-3032",
                    Email = "cherrith@marritimelaw.com",
                    IsPresenter = false,
                    IsStaff = false,
                    DateRegistered = DateTime.Today
                },
                new Attendee
                {
                    ID = 104,
                    FirstName = "Friz",
                    LastName = "Freeling",
                    Phone = "303-303-3033",
                    Email = "friz@wb.com",
                    IsPresenter = true,
                    IsStaff = false,
                    DateRegistered = DateTime.Today
                },
                new Attendee
                {
                    ID = 105,
                    FirstName = "Wile E",
                    LastName = "Coyote",
                    Phone = "303-303-3034",
                    Email = "wil@varoom.com",
                    IsPresenter = true,
                    IsStaff = false,
                    DateRegistered = DateTime.Today
                },
                new Attendee
                {
                    ID = 106,
                    FirstName = "Bill",
                    LastName = "Smith",
                    Phone = "303-303-3035",
                    Email = "bill@compuserve.com",
                    IsPresenter = false,
                    IsStaff = false,
                    DateRegistered = DateTime.Today
                },
            };
        }

        private void InitalizeVenues()
        {
            venues = new List<Venue>()
            {
                new Venue
                {
                    ID = 10,
                    Name = "Colorado Convention Center",
                    Address1 = "700 14th St",
                    City = "Denver",
                    State = "CO",
                    PostalCode = "80202",
                    Phone = "303-303-0000"
                },
                new Venue
                {
                    ID = 11,
                    Name = "The Curtis Hotel",
                    Address1 = "1405 Curtis St",
                    City = "Denver",
                    State = "CO",
                    PostalCode = "80202",
                    Phone = "720-303-0000"
                }
            };
        }

        private void InitalizeRooms()
        {
            rooms = new List<Room>()
            {
                new Room
                {
                    ID = 1010,
                    VenueID = 10,
                    Name = "101",
                    TheatreCapacity = 100,
                    SchoolRoomCapacity = 50,
                    CrescentRoundCapacity = 65
                },
                new Room
                {
                    ID = 1011,
                    VenueID = 10,
                    Name = "201",
                    TheatreCapacity = 100,
                    SchoolRoomCapacity = 50,
                    CrescentRoundCapacity = 65
                },
                new Room
                {
                    ID = 1012,
                    VenueID = 10,
                    Name = "Mile High Ballroom",
                    TheatreCapacity = 1000,
                    SchoolRoomCapacity = 500,
                    CrescentRoundCapacity = 650
                },
                new Room
                {
                    ID = 1013,
                    VenueID = 11,
                    Name = "Marco Polo Ballroom",
                    TheatreCapacity = 500,
                    SchoolRoomCapacity = 250,
                    CrescentRoundCapacity = 350
                },
                new Room
                {
                    ID = 1014,
                    VenueID = 11,
                    Name = "Red Rover",
                    TheatreCapacity = 100,
                    SchoolRoomCapacity = 50,
                    CrescentRoundCapacity = 65
                },
            };
        }

        private void InitalizePresentations()
        {
            presentations = new List<Presentation>()
            {
                new Presentation
                {
                    ID = 101,
                    ConferenceID = 1001,
                    AttendeeID = 102,
                    RoomID = 1010,
                    Name = "Professional Associations in the 21st century",
                    Description = "Hear our president discuss the role of professional organizations in the 21st century",
                    StartTime = DateTime.Now.AddDays(1),
                    EndTime = DateTime.Now.AddHours(2).AddDays(1)
                },
                new Presentation
                {
                    ID = 102,
                    ConferenceID = 1001,
                    AttendeeID = 101,
                    RoomID = 1011,
                    Name = "Member Services",
                    Description = "Join a discussion about the various services a professional organization can offer it's members",
                    StartTime = DateTime.Now.AddDays(2),
                    EndTime = DateTime.Now.AddHours(2).AddDays(2)
                },
                new Presentation
                {
                    ID = 103,
                    ConferenceID = 1002,
                    AttendeeID = 104,
                    RoomID = 1011,
                    Name = "Paint Application in Aird Climates",
                    Description = "Learn about the proper application of our tunnel paint in dry arid climates.",
                    StartTime = DateTime.Now.AddDays(2),
                    EndTime = DateTime.Now.AddHours(2).AddDays(2)
                },
                new Presentation
                {
                    ID = 104,
                    ConferenceID = 1002,
                    AttendeeID = 105,
                    RoomID = 1013,
                    Name = "Acme Orbital",
                    Description = "Our rockets aren't just for hunting! Come hear about Acme's plans to land the first coyote on the moon",
                    StartTime = DateTime.Now.AddDays(2),
                    EndTime = DateTime.Now.AddHours(2).AddDays(2)
                },
            };
        }

        private void InitalizeEventAttendees()
        {
            eventAttendees = new List<EventAttendees>();

            KeyValuePair<int, int> d = new KeyValuePair<int, int>(101, 101);
            presentationAttendees.Add(d);

            d = new KeyValuePair<int, int>(101, 102);
            presentationAttendees.Add(d);

            d = new KeyValuePair<int, int>(101, 103);
            presentationAttendees.Add(d);

            d = new KeyValuePair<int, int>(103, 101);
            presentationAttendees.Add(d);

            d = new KeyValuePair<int, int>(103, 103);
            presentationAttendees.Add(d);

            d = new KeyValuePair<int, int>(104, 104);
            presentationAttendees.Add(d);

            d = new KeyValuePair<int, int>(104, 105);
            presentationAttendees.Add(d);

            d = new KeyValuePair<int, int>(105, 104);
            presentationAttendees.Add(d);

            d = new KeyValuePair<int, int>(105, 105);
            presentationAttendees.Add(d);

            d = new KeyValuePair<int, int>(105, 106);
            presentationAttendees.Add(d);
        }

        private void InitalizeConferenceVenues()
        {
            conferenceVenues = new List<KeyValuePair<int, int>>();

            KeyValuePair<int, int> d = new KeyValuePair<int, int>(1001, 10);
            conferenceVenues.Add(d);

            d = new KeyValuePair<int, int>(1002, 11);
            conferenceVenues.Add(d);
        }

        private void InitalizeConferenceAttendees()
        {
            conferenceAttendees = new List<KeyValuePair<int, int>>();

            KeyValuePair<int, int> d = new KeyValuePair<int, int>(1001, 101);
            conferenceAttendees.Add(d);

            d = new KeyValuePair<int, int>(1001, 102);
            conferenceAttendees.Add(d);

            d = new KeyValuePair<int, int>(1001, 103);
            conferenceAttendees.Add(d);

            d = new KeyValuePair<int, int>(1002, 104);
            conferenceAttendees.Add(d);

            d = new KeyValuePair<int, int>(1003, 105);
            conferenceAttendees.Add(d);

            d = new KeyValuePair<int, int>(1004, 106);
            conferenceAttendees.Add(d);
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public T Get(int id)
        {
            throw new NotImplementedException();
        }

        public T Get(QueryOptions<T> options)
        {
            throw new NotImplementedException();
        }

        public void Insert(T entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> List(QueryOptions<T> options)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
