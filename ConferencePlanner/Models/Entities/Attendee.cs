using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ConferenceManager.Models.Entities
{
    public class Attendee
    {
        public int AttendeeID { get; set; }
        //public virtual ICollection<ConferenceAttendees> ConferenceAttendees { get; set; }
        //public ICollection<EventAttendees> EventAttendees { get; set; }

        [Required(ErrorMessage = "Please enter a first name")]
        [StringLength(20)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please select enter a last name")]
        [StringLength(20)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter a phone number")]
        [RegularExpression(@"^((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}$",
            ErrorMessage = "Phone number must be in (999) 999-9999 format.")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please select an email address")]
        [StringLength(50)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

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
