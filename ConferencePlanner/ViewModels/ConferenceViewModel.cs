using ConferenceManager.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConferenceManager.ViewModels
{
    public class ConferenceViewModel
    {
        public Conference Conference { get; set; }
        public IEnumerable<ConferenceAttendee> Attendees { get; set; }
        public IEnumerable<ConferenceVenue> Venues { get; set; }
    }
}
