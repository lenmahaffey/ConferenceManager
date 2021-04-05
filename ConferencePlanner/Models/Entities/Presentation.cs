using ConferenceManager.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ConferenceManager.Models
{
    public class Presentation : Event
    {
        public int AttendeeID { get; set; }
        public Attendee Attendee { get; set; } // for presenter
    }
}
