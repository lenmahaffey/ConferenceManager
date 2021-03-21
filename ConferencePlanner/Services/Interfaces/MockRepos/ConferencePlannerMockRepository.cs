﻿using ConferencePlanner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConferencePlanner.Services.Interfaces.MockRepos
{
    public class ConferencePlannerMockRepository : IConferencePlannerData
    {
        private List<Attendee> attendees;
        private List<Conference> conferences;
        private List<Presentation> presentations;
        private List<Room> rooms;
        private List<Venue> venues;
        private List<Dictionary<int, int>> conferenceAttendees;
        private List<Dictionary<int, int>> conferenceVenues;
        private List<Dictionary<int, int>> presentationAttendees;

        public ConferencePlannerMockRepository()
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
                    ConferenceID = 1001,
                    Name = "International Association of National Associations",
                    Description = "The largest gathering of national association directors and managers in the world.",
                    StartDate = DateTime.Today,
                    EndDate = DateTime.Today.AddDays(4)
                },
                new Conference
                {
                    ConferenceID = 1002,
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
                    AttendeeID = 101,
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
                    AttendeeID = 102,
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
                    AttendeeID = 103,
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
                    AttendeeID = 104,
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
                    AttendeeID = 105,
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
                    AttendeeID = 106,
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
                    VenueID = 10,
                    Name = "Colorado Convention Center",
                    Address1 = "700 14th St",
                    City = "Denver",
                    State = "CO",
                    PostalCode = "80202",
                    Phone = "303-303-0000"
                },
                new Venue
                {
                    VenueID = 11,
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
                    CrescentRoundCpacity = 65
                },
                new Room
                {
                    RoomID = 1011,
                    VenueID = 10,
                    Name = "201",
                    TheatreCapacity = 100,
                    SchoolRoomCapacity = 50,
                    CrescentRoundCpacity = 65
                },
                new Room
                {
                    RoomID = 1012,
                    VenueID = 10,
                    Name = "Mile High Ballroom",
                    TheatreCapacity = 1000,
                    SchoolRoomCapacity = 500,
                    CrescentRoundCpacity = 650
                },
                new Room
                {
                    RoomID = 1013,
                    VenueID = 11,
                    Name = "Marco Polo Ballroom",
                    TheatreCapacity = 500,
                    SchoolRoomCapacity = 250,
                    CrescentRoundCpacity = 350
                },
                new Room
                {
                    RoomID = 1014,
                    VenueID = 11,
                    Name = "Red Rover",
                    TheatreCapacity = 100,
                    SchoolRoomCapacity = 50,
                    CrescentRoundCpacity = 65
                },
            };
        }

        private void InitalizePresentations()
        {
            presentations = new List<Presentation>()
            {
                new Presentation
                {
                    PresentationID = 101,
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
                    PresentationID = 102,
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
                    PresentationID = 103,
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
                    PresentationID = 104,
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
            presentationAttendees = new List<Dictionary<int, int>>();

            Dictionary<int, int> d = new Dictionary<int,int>();
            d.Add(101, 101);
            presentationAttendees.Add(d);

            d = new Dictionary<int, int>();
            d.Add(101, 102);
            presentationAttendees.Add(d);

            d = new Dictionary<int, int>();
            d.Add(101, 103);
            presentationAttendees.Add(d);

            d = new Dictionary<int, int>();
            d.Add(103, 101);
            presentationAttendees.Add(d);

            d = new Dictionary<int, int>();
            d.Add(103, 103);
            presentationAttendees.Add(d);

            d = new Dictionary<int, int>();
            d.Add(104, 104);
            presentationAttendees.Add(d);

            d = new Dictionary<int, int>();
            d.Add(104, 105);
            presentationAttendees.Add(d);

            d = new Dictionary<int, int>();
            d.Add(105, 104);
            presentationAttendees.Add(d);

            d = new Dictionary<int, int>();
            d.Add(105, 105);
            presentationAttendees.Add(d);

            d = new Dictionary<int, int>();
            d.Add(105, 106);
            presentationAttendees.Add(d);

        }

        private void InitalizeConferenceVenues()
        {
            conferenceVenues = new List<Dictionary<int, int>>();

            Dictionary<int, int> d = new Dictionary<int, int>();
            d.Add(1001, 10);
            conferenceVenues.Add(d);

            d = new Dictionary<int, int>();
            d.Add(1002, 11);
            conferenceVenues.Add(d);
        }

        private void InitalizeConferenceAttendees()
        {
            conferenceAttendees = new List<Dictionary<int, int>>();

            Dictionary<int, int> d = new Dictionary<int, int>();
            d.Add(1001, 101);
            conferenceAttendees.Add(d);

            d = new Dictionary<int, int>();
            d.Add(1001, 102);
            conferenceAttendees.Add(d);

            d = new Dictionary<int, int>();
            d.Add(1001, 103);
            conferenceAttendees.Add(d);

            d = new Dictionary<int, int>();
            d.Add(1002, 104);
            conferenceAttendees.Add(d);

            d = new Dictionary<int, int>();
            d.Add(1003, 105);
            conferenceAttendees.Add(d);

            d = new Dictionary<int, int>();
            d.Add(1004, 106);
            conferenceAttendees.Add(d);
        }

        public void AddAttendee(Attendee attendee)
        {
            attendees.Add(attendee);
        }

        public void AddAttendeeToConference(Conference conference, Attendee attendee)
        {
            throw new NotImplementedException();
            /*
            Dictionary<int, int> d = new Dictionary<int, int>();
            d.Add(conference.ConferenceID, attendee.AttendeeID);
            conferenceAttendees.Add(d);
            */
        }

        public void AddConference(Conference conference)
        {
            conferences.Add(conference);
        }

        public void AddPresentation(Presentation presentation)
        {
            presentations.Add(presentation);
        }

        public void AddRooms(Room room)
        {
            rooms.Add(room);
        }

        public void AddVenue(Venue venue)
        {
            venues.Add(venue);
        }

        public void AddVenueToConference(Conference conference, Venue venue)
        {
            throw new NotImplementedException();
            /*
            Dictionary<int, int> d = new Dictionary<int, int>();
            d.Add(conference.ConferenceID, venue.VenueID);
            conferenceVenues.Add(d);
            */
        }

        public void DeleteAttendee(Attendee attendee)
        {
            attendees.Remove(attendee);
        }

        public void DeleteConference(Conference conference)
        {
            conferences.Remove(conference);
        }

        public void DeletePresentation(Presentation presentation)
        {
            presentations.Remove(presentation);
        }

        public void DeleteRooms(Room room)
        {
            rooms.Remove(room);
        }

        public void DeleteVenue(Venue venue)
        {
            venues.Remove(venue);
        }

        public void EditAttendee(Attendee attendee)
        {
            throw new NotImplementedException();
        }

        public void EditConference(Conference Conference)
        {
            throw new NotImplementedException();
        }

        public void EditPresentation(Presentation presentation)
        {
            throw new NotImplementedException();
        }

        public void EditRooms(Room rooms)
        {
            throw new NotImplementedException();
        }

        public void EditVenue(Venue venue)
        {
            throw new NotImplementedException();
        }

        public Attendee GetAttendee(int id)
        {
            return attendees.FirstOrDefault(a => a.AttendeeID == id);
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

        public IEnumerable<Attendee> GetAllAttendeesForConference(int conferenceID)
        {
            throw new NotImplementedException();
            //return (IEnumerable<Attendee>)conferenceAttendees.SelectMany(a => a).Where(key => key.Key == conferenceID).ToList();
        }

        public IEnumerable<Attendee> GetAllAttendeesForPresentation(int presentationID)
        {
            throw new NotImplementedException();
            //return (IEnumerable<Attendee>)presentationAttendees.SelectMany(a => a).Where(key => key.Key == presentationID).ToList();
        }

        public IEnumerable<Presentation> GetAllPresentationsForAttendee(int attendeeID)
        {
            throw new NotImplementedException();
            //return (IEnumerable<Attendee>)presentationAttendees.SelectMany(p => p).Where(v => v.Value == attendeeID).ToList();
        }
        public IEnumerable<Conference> GetAllConferencesForAttendee(int attendeeID)
        {
            throw new NotImplementedException();
            //return (IEnumerable<Attendee>)conferenceAttendees.SelectMany(c => c).Where(v => v.Value == attendeeID).ToList();
        }
        public Conference GetConference(int id)
        {
            return conferences.FirstOrDefault(c => c.ConferenceID == id);
        }

        public IEnumerable<Conference> GetConferences()
        {
            foreach (Conference conference in conferences)
            {
                foreach (var dict in conferenceAttendees)
                {
                    foreach (var pair in dict)
                    {
                        if (pair.Key == conference.ConferenceID)
                        {
                            //conference.ConferenceAttendees = (IEnumerable<ConferenceAttendees>)GetAllAttendeesForConference(pair.Key);
                        }
                    }
                }

                foreach (var dict in conferenceVenues)
                {
                    foreach (var pair in dict)
                    {
                        if (pair.Key == conference.ConferenceID)
                        {
                            //conference.ConferenceVenues = (IEnumerable<ConferenceVenues>)GetAllVenuesForConference(pair.Key);
                        }
                    }
                }
            }
            return from c in conferences
                   orderby c.Name
                   select c;
        }

        public IEnumerable<Venue> GetAllVenuesForConference(int conferenceID)
        {
            throw new NotImplementedException();
            //return (IEnumerable<Venue>)conferenceVenues.SelectMany(v => v).Where(key => key.Key == conferenceID).ToList();
        }

        public IEnumerable<Conference> GetAllConferencesForVenue(int venueID)
        {
            throw new NotImplementedException();
            //return (IEnumerable<Venue>)conferenceVenues.SelectMany(v => v).Where(v => v.Value == venueID).ToList();
        }

        public Room GetRoom(int id)
        {
            return rooms.FirstOrDefault(r => r.RoomID == id);
        }

        public IEnumerable<Room> GetRooms()
        {
            foreach (Room room in rooms)
            {
                room.Venue = venues.FirstOrDefault(v => room.VenueID == v.VenueID);
            }
            return from r in rooms
                   orderby r.Name
                   select r;
        }

        public IEnumerable<Room> GetAllRoomsForVenue(int venueID)
        {
            return from v in rooms
                   where v.VenueID == venueID
                   select v;
        }

        public Presentation GetPresentation(int id)
        {
            return presentations.FirstOrDefault(p => p.PresentationID == id);
        }

        public IEnumerable<Presentation> GetPresentations()
        {
            foreach (Presentation presentation in presentations)
            {
                //presentation.PresentationAttendees = (ICollection<PresentationAttendees>)GetAllAttendeesForPresentation(presentation.PresentationID);
                presentation.Conference = GetConference(presentation.ConferenceID);
                presentation.Presenter = GetAttendee(presentation.AttendeeID);
                GetRooms();
                presentation.Room = GetRoom(presentation.RoomID);
            }
            return from p in presentations
                   orderby p.Name
                   select p;
        }

        public Venue GetVenue(int id)
        {
            return venues.FirstOrDefault(v => v.VenueID == id);
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

        public void RemoveAttendeeFromConference(Conference conference, Attendee attendee)
        {
            throw new NotImplementedException();
        }

        public void RemovePresentationFromConference(Conference conference, Presentation presentation)
        {
            throw new NotImplementedException();
        }

        public void RemoveVenueFromConference(Conference conference, Attendee attendee)
        {
            throw new NotImplementedException();
        }

        public void AddVenueToConference(Conference conference, Attendee attendee)
        {
            throw new NotImplementedException();
        }

        public void AddAttendeeToPresentation(Presentation presentation, Attendee attendee)
        {
            throw new NotImplementedException();
        }

        public void RemoveAttendeeFromPresentation(Presentation presentation, Attendee attendee)
        {
            throw new NotImplementedException();
        }
    }
}