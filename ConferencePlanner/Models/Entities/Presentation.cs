using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConferenceManager.Models.Entities
{
    public class Presentation : Event
    {
        public int AttendeeID { get; set; }
        public virtual Attendee Attendee { get; set; } // for presenter
    }
}
