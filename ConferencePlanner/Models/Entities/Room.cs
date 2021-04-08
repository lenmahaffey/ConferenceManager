using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConferenceManager.Models.Entities
{
    public class Room
    {
        public int ID { get; set; }

        [Required]
        public int VenueID { get; set; }
        public virtual Venue Venue { get; set; }

        public virtual ICollection<Presentation> Events { get; set; }

        [Required(ErrorMessage = "Please enter the name of the room")]
        [StringLength(50)]
        public string Name { get; set; }

        public int? TheatreCapacity { get; set; }
        public int? SchoolRoomCapacity { get; set; }
        public int? CrescentRoundCapacity { get; set; }
    }
}
