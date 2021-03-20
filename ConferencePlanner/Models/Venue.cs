using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ConferencePlanner.Models
{
    public class Venue
    {
        public int VenueID { get; set; }

        public ICollection<Room> Rooms { get; set; }

        [Required(ErrorMessage = "Please enter the name of the venue")]
        [StringLength(50)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter the address")]
        [StringLength(20)]
        public string Address1 { get; set; }

        [StringLength(20)]
        public string Address2 { get; set; }

        [Required(ErrorMessage = "Please enter the city")]
        [StringLength(20)]
        public string City { get; set; }

        [Required(ErrorMessage = "Please enter the state in XX (two letter abbreviation) format")]
        [StringLength(2)]
        public string State { get; set; }

        [Required(ErrorMessage = "Please enter the postal code")]
        [StringLength(20)]
        public int PostalCode { get; set; }

        [Required(ErrorMessage = "Please enter the phone number")]
        [RegularExpression(@"^((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}$",
            ErrorMessage = "Phone number must be in (999) 999-9999 format.")]
        public string Phone { get; set; }
    }
}
