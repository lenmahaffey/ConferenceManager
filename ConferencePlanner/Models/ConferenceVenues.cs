using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConferenceManager.Models
{
    public class ConferenceVenues
    {
        public int ConferenceID { get; set; }
        public int VenueID { get; set; }

        public Conference Conference { get; set; }
        public Venue Venue { get; set; }
    }
}
