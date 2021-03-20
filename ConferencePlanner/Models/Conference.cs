﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConferencePlanner.Models
{
    public class Conference
    {
        [Required]
        public int ConferenceID { get; set; }

        public IEnumerable<ConferenceAttendees> ConferenceAttendees { get; set; }
        public IEnumerable<ConferenceVenues> ConferenceVenues { get; set; }

        [Required(ErrorMessage = "Please enter the name of the conference")]
        [StringLength(50)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter a start date")]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "Please enter an end date")]
        public DateTime EndDate { get; set; }
    }
}
