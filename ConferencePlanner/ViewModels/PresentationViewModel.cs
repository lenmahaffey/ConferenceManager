using ConferenceManager.Models.Entities;
using System.Collections.Generic;

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
