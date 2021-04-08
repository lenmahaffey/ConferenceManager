using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConferenceManager.Models.Entities
{
    public class Presentation : Event
    {
        public int AttendeeID { get; set; }
        public virtual Attendee Attendee { get; set; } // for presenter
    }
}
