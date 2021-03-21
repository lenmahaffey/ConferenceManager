using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConferenceManager.Models
{
    public class ConferenceAttendees
    {
        public int ConferenceID { get; set; }
        public int AttendeeID { get; set; }

        public Conference Conference { get; set; }
        public Attendee Attendee { get; set; }
    }
}
