﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ConferenceManager.Models.Entities
{
    public class Room
    {
        [Required]
        public int RoomID { get; set; }

        [Required]
        public int VenueID { get; set; }
        public Venue Venue { get; set; }

        public ICollection<Presentation> Presentations { get; set; }

        [Required(ErrorMessage = "Please enter the name of the room")]
        [StringLength(50)]
        public string Name { get; set; }

        public int? TheatreCapacity { get; set; }
        public int? SchoolRoomCapacity { get; set; }
        public int? CrescentRoundCapacity { get; set; }
    }
}
