using ConferenceManager.Models.Entities;
using System.Collections.Generic;

namespace ConferenceManager.ViewModels
{
    public class ConferenceViewModel
    {
        public Conference Conference { get; set; }
        public IEnumerable<Attendee> Attendees { get; set; }
        public IEnumerable<Venue> Venues { get; set; }
    }
}
