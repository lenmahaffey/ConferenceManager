using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ConferenceManager.Models.Entities
{
    public class Attendee : Contact
    {
        public virtual ICollection<ConferenceAttendee> ConferenceAttendees { get; set; }
        public virtual ICollection<EventAttendee> EventAttendees { get; set; }

        [Required(ErrorMessage = "Please enter a first name")]
        [StringLength(20)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please select enter a last name")]
        [StringLength(20)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter the date the attendee registered")]
        public DateTime DateRegistered { get; set; }

        [Required(ErrorMessage ="Please enter yes or no")]
        public bool IsPresenter { get; set; }

        [Required(ErrorMessage = "Please enter yes or no")]
        public bool IsStaff { get; set; }

        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
    }
}
