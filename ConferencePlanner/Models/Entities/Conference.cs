using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConferenceManager.Models.Entities
{
    public class Conference
    {
        public int ID { get; set; }

        public virtual ICollection<ConferenceAttendee> ConferenceAttendees { get; set; }
        public virtual ICollection<ConferenceVenue> ConferenceVenues { get; set; }
        public virtual ICollection<Event> Presentations { get; set; }

        [Required(ErrorMessage = "Please enter the name of the conference")]
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        [Required(ErrorMessage = "Please enter a start date")]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "Please enter an end date")]
        public DateTime EndDate { get; set; }
    }
}
