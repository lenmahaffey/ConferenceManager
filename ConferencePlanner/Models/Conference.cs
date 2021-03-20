using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ConferencePlanner.Models
{
    public class Conference
    {
        [Required]
        public int ConferenceID { get; set; }

        public IEnumerable<Presentation> Presentations { get; set; }

        [Required(ErrorMessage = "Please enter the name of the conference")]
        [StringLength(50)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter a start date")]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "Please enter an end date")]
        public DateTime EndDate { get; set; }
    }
}
