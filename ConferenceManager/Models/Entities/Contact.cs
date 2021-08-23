using System.ComponentModel.DataAnnotations;

namespace ConferenceManager.Models.Entities
{
    abstract public class Contact
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Please enter a phone number")]
        [RegularExpression(@"^((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}$",
            ErrorMessage = "Phone number must be in (999) 999-9999 format.")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please select an email address")]
        [StringLength(50)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set;}
        public string Country { get; set; }

    }
}
