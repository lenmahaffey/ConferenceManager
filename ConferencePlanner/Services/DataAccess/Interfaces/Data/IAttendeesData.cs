using ConferenceManager.Models.Entities;
using System.Collections.Generic;

namespace ConferenceManager.Services.Interfaces
{
    interface IAttendeesData
    {
        Attendee GetAttendee(int id);
        IEnumerable<Attendee> GetAttendees();
        void DeleteAttendee(Attendee attendee);
        public void AddAttendee(Attendee attendee);
        public void EditAttendee(Attendee attendee);
    }
}
