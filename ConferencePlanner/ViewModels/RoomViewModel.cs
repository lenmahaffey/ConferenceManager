using ConferenceManager.Models.Entities;
using System.Collections.Generic;

namespace ConferenceManager.ViewModels
{
    public class RoomViewModel
    {
        public Room Room { get; set; }
        public Venue Venue { get; set; }
        public IEnumerable<Venue> Venues { get; set; }
    }
}
