using ConferenceManager.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ConferenceManager.Services.Interfaces.MockRepos
{
    public class ConferenceManagerMockRepository : IConferenceManagerData
    {
        private List<Attendee> attendees;
        private List<Conference> conferences;
        private List<Presentation> presentations;
        private List<Room> rooms;
        private List<Venue> venues;
        private List<KeyValuePair<int, int>> conferenceAttendees;
        private List<KeyValuePair<int, int>> conferenceVenues;
        private List<KeyValuePair<int, int>> presentationAttendees;

        public ConferenceManagerMockRepository()
        {
            if (attendees == null)
            {
                InitializeAttendees();
            }

            if(conferences == null)
            {
                InitalizeConferences();
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
            if (presentationAttendees == null)
            {
                InitalizePresentationAttendees();
            }

        }

        private void InitalizeConferences()
        {
            conferences = new List<Conference>()
            {
                new Conference
                {
                    ID = 1001,
                    Name = "International Association of National Associations",
                    Description = "The largest gathering of national association directors and managers in the world.",
                    StartDate = DateTime.Today,
                    EndDate = DateTime.Today.AddDays(4)
                },
                new Conference
                {
                    ID = 1002,
                    Name = "Acme Corp",
                    Description = "An exposition of the latest in roadrunner hunting equipment",
                    StartDate = DateTime.Today.AddDays(5),
                    EndDate = DateTime.Today.AddDays(9)
                }
            };
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
                    RoomID = 1010,
                    VenueID = 10,
                    Name = "101",
                    TheatreCapacity = 100,
                    SchoolRoomCapacity = 50,
                    CrescentRoundCapacity = 65
                },
                new Room
                {
                    RoomID = 1011,
                    VenueID = 10,
                    Name = "201",
                    TheatreCapacity = 100,
                    SchoolRoomCapacity = 50,
                    CrescentRoundCapacity = 65
                },
                new Room
                {
                    RoomID = 1012,
                    VenueID = 10,
                    Name = "Mile High Ballroom",
                    TheatreCapacity = 1000,
                    SchoolRoomCapacity = 500,
                    CrescentRoundCapacity = 650
                },
                new Room
                {
                    RoomID = 1013,
                    VenueID = 11,
                    Name = "Marco Polo Ballroom",
                    TheatreCapacity = 500,
                    SchoolRoomCapacity = 250,
                    CrescentRoundCapacity = 350
                },
                new Room
                {
                    RoomID = 1014,
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

        private void InitalizePresentationAttendees()
        {
            presentationAttendees = new List<KeyValuePair<int, int>>();

            KeyValuePair<int, int> d = new KeyValuePair<int,int>(101, 101);
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

        public IEnumerable GetAllAttendeesForConference(int conferenceID)
        {
            List<ConferenceAttendees> list = new List<ConferenceAttendees>();
            foreach (var pair in conferenceAttendees)
            {
                if (pair.Key == conferenceID)
                {
                    ConferenceAttendees data = new ConferenceAttendees
                    {
                        ConferenceID = pair.Key,
                        AttendeeID = pair.Value,
                        Conference = GetConference(pair.Key),
                        Attendee = GetAttendee(pair.Value)
                    };
                }
            }
            return list;
        }

        public IEnumerable GetAllConferencesForAttendee(int attendeeID)
        {
            List<ConferenceAttendees> list = new List<ConferenceAttendees>();

            foreach (var pair in conferenceAttendees)
            {
                if (pair.Value == attendeeID)
                {
                    ConferenceAttendees data = new ConferenceAttendees
                    {
                        ConferenceID = pair.Key,
                        AttendeeID = pair.Value,
                        Conference = GetConference(pair.Key),
                        Attendee = GetAttendee(pair.Value)
                    };
                }
            }

            return list;
        }

        public Attendee GetAttendee(int id)
        {
            foreach (Attendee a in attendees)
            {
                if (a.ID == id)
                {
                    foreach (var pair in conferenceAttendees)
                    {
                        if(pair.Value == a.ID)
                        {
                            if (a.ConferenceAttendees == null)
                            {
                                a.ConferenceAttendees = new List<ConferenceAttendees>();
                            }

                            a.ConferenceAttendees.Add(new ConferenceAttendees
                            {
                                AttendeeID = a.ID,
                                Attendee = a,
                                ConferenceID = pair.Key,
                                Conference = GetConference(pair.Key)
                            });
                        }
                    }
                    return a;
                }
            }
            return null;
        }

        public IEnumerable<Attendee> GetAttendees()
        {
            /*
            foreach (Attendee attendee in attendees)
            {
                attendee.ConferenceAttendees = (ICollection<ConferenceAttendees>)GetAllConferencesForAttendee(attendee.AttendeeID);
                attendee.PresentationAttendees = (ICollection<PresentationAttendees>)GetAllPresentationsForAttendee(attendee.AttendeeID);
            }
            */
            return from a in attendees
                   orderby a.LastName
                   select a;
        }

        public Conference GetConference(int id)
        {
            return conferences.FirstOrDefault(c => c.ID == id);
        }

        public IEnumerable<Conference> GetConferences()
        {
            //foreach (Conference conference in conferences)
            //{
            //    foreach (var dict in conferenceAttendees)
            //    {
            //        foreach (var pair in dict)
            //        {
            //            if (pair.Key == conference.ConferenceID)
            //            {
            //                //conference.ConferenceAttendees = (IEnumerable<ConferenceAttendees>)GetAllAttendeesForConference(pair.Key);
            //            }
            //        }
            //    }

            //    foreach (var dict in conferenceVenues)
            //    {
            //        foreach (var pair in dict)
            //        {
            //            if (pair.Key == conference.ConferenceID)
            //            {
            //                //conference.ConferenceVenues = (IEnumerable<ConferenceVenues>)GetAllVenuesForConference(pair.Key);
            //            }
            //        }
            //    }
            //}
            return from c in conferences
                   orderby c.Name
                   select c;
        }

        public Room GetRoom(int id)
        {
            foreach (Room r in rooms)
            {
                if (r.RoomID == id)
                {
                    return r;
                }
            }
            return null;
        }

        public IEnumerable<Room> GetRooms()
        {
            foreach (Room room in rooms)
            {
                room.Venue = venues.FirstOrDefault(v => room.VenueID == v.ID);
            }
            return from r in rooms
                   orderby r.Name
                   select r;
        }

        public Presentation GetPresentation(int id)
        {
            return presentations.FirstOrDefault(p => p.ID == id);
        }

        public IEnumerable<Presentation> GetPresentations()
        {
            foreach (Presentation presentation in presentations)
            {
                //presentation.PresentationAttendees = (ICollection<PresentationAttendees>)GetAllAttendeesForPresentation(presentation.PresentationID);
                presentation.Conference = GetConference(presentation.ConferenceID);
                presentation.Attendee = GetAttendee(presentation.AttendeeID);
                GetRooms();
                presentation.Room = GetRoom(presentation.RoomID);
            }
            return from p in presentations
                   orderby p.Name
                   select p;
        }

        public Venue GetVenue(int id)
        {
            return venues.FirstOrDefault(v => v.ID == id);
        }

        public IEnumerable<Venue> GetVenues()
        {
            foreach (Venue venue in venues)
            {
                /*
                venue.Rooms = GetAllRoomsForVenue(venue.VenueID);
                foreach (var dict in conferenceVenues)
                {
                    foreach (var pair in dict)
                    {
                        //venue.ConferenceVenues = (IEnumerable<ConferenceVenues>)GetAllConferencesForVenue(pair.Key);
                    }
                }
                */
            }
            return from v in venues
                   orderby v.Name
                   select v;
        }

        public void AddAttendee(Attendee attendee)
        {
            attendees.Add(attendee);
        }

        public void AddConference(Conference conference)
        {
            conferences.Add(conference);
        }

        public void AddPresentation(Presentation presentation)
        {
            presentations.Add(presentation);
        }

        public void AddRoom(Room room)
        {
            rooms.Add(room);
        }

        public void AddVenue(Venue venue)
        {
            venues.Add(venue);
        }

        public void DeleteAttendee(Attendee attendee)
        {
            attendee = GetAttendee(attendee.ID);
            int index = 0;
            foreach (Attendee a in attendees)
            {
                if (a.ID == attendee.ID)
                {
                    attendees.RemoveAt(index);
                    break;
                }
                index++;
            }
        }

        public void DeleteConference(Conference conference)
        {
            int index = 0;
            foreach (Conference c in conferences)
            {
                if (c.ID == conference.ID)
                {
                    conferences.RemoveAt(index);
                    break;
                }
                index++;
            }
        }

        public void DeletePresentation(Presentation presentation)
        {
            int index = 0;
            foreach (Presentation p in presentations)
            {
                if (p.ID == presentation.ID)
                {
                    presentations.RemoveAt(index);
                    break;
                }
                index++;
            }
        }

        public void DeleteVenue(Venue venue)
        {
            int index = 0;
            foreach (Venue v in venues)
            {
                if (v.ID == venue.ID)
                {
                    venues.RemoveAt(index);
                    break;
                }
                index++;
            }
        }

        public void DeleteRoom(Room room)
        {
            int index = 0;
            foreach (Room r in rooms)
            {
                if (r.RoomID == room.RoomID)
                {
                    rooms.RemoveAt(index);
                    break;
                }
                index++;
            }
        }

        public void EditAttendee(Attendee attendee)
        {
            attendees[attendees.FindIndex(i => i.ID == attendee.ID)] = attendee;
        }

        public void EditConference(Conference conference)
        {
            conferences[conferences.FindIndex(i => i.ID == conference.ID)] = conference;
        }

        public void EditVenue(Venue venue)
        {
            venues[venues.FindIndex(i => i.ID == venue.ID)] = venue;
        }

        public void EditRoom(Room Room)
        {
            rooms[rooms.FindIndex(i => i.RoomID == Room.RoomID)] = Room;
        }
        public void EditPresentation(Presentation presentation)
        {
            presentations[presentations.FindIndex(i => i.ID == presentation.ID)] = presentation;
        }
    }
}
