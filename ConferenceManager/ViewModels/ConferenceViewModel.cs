using ConferenceManager.Models.Entities;
using System.Collections.Generic;

namespace ConferenceManager.ViewModels
{
    public class ConferenceViewModel
    {
        public Conference Conference { get; set; }
        public IEnumerable<ConferenceAttendee> Attendees { get; set; }
        public IEnumerable<ConferenceVenue> Venues { get; set; }
    }
}
