using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ConferenceManager.Models
{
    public class Presentation
    {
        [Required]
        public int PresentationID { get; set; }

        public ICollection<PresentationAttendees> PresentationAttendees { get; set; }
        [Required]
        public int ConferenceID { get; set; }
        public Conference Conference { get; set; }

        [Required]
        public int AttendeeID { get; set; }
        public Attendee Attendee { get; set; } // for presenter
        [Required]
        public int RoomID { get; set; }
        public Room Room { get; set; }

        [Required(ErrorMessage = "Please enter an start date")]
        public DateTime StartTime { get; set; }

        [Required(ErrorMessage = "Please enter an end date")]
        public DateTime EndTime { get; set; }

        [Required(ErrorMessage = "Please enter the name of the presentation")]
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(255)]
        public string Description { get; set; }
    }
}
