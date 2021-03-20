using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConferencePlanner.Models
{
    public class Room
    {
        [Required]
        public int RoomID { get; set; }

        [Required]
        public int VenueID { get; set; }

        [NotMapped]
        public ICollection<Presentation> Presentations { get; set; }

        [Required(ErrorMessage = "Please enter the name of the room")]
        [StringLength(50)]
        public string Name { get; set; }

        public int? TheatreCapacity { get; set; }
        public int? SchoolRoomCapacity { get; set; }
        public int? CrescentRoundCpacity { get; set; }
    }
}
