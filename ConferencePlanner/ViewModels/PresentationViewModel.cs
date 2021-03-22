using ConferenceManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConferenceManager.ViewModels
{
    public class PresentationViewModel
    {
        public Presentation Presentation { get; set; }
        public Attendee Attendee { get; set; }
        public Conference Conference { get; set; }
        public Room Room { get; set; }
        public IEnumerable<Room> Rooms { get; set; }
        public IEnumerable<Attendee> Attendees { get; set; }
        public IEnumerable<Conference> Conferences { get; set; }
    }
}
