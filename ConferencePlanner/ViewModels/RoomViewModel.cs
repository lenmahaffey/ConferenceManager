using ConferenceManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConferenceManager.ViewModels
{
    public class RoomViewModel
    {
        public Room Room { get; set; }
        public Venue Venue { get; set; }
        public IEnumerable<Venue> Venues { get; set; }
    }
}
