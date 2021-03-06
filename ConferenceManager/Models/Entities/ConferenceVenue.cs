namespace ConferenceManager.Models.Entities
{
    public class ConferenceVenue
    {
        public int ConferenceID { get; set; }
        public int VenueID { get; set; }

        public virtual Conference Conference { get; set; }
        public virtual Venue Venue { get; set; }
    }
}
