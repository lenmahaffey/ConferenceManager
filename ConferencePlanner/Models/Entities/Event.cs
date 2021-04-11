using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConferenceManager.Models.Entities
{
    abstract public class Event
    {
        [Key]
        public int ID { get; set; }
        public int ConferenceID { get; set; }
        public virtual ICollection<EventAttendees> EventAttendees { get; set; }
        public virtual Conference Conference { get; set; }

        public int RoomID { get; set; }
        public virtual Room Room { get; set; }

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
