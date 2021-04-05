namespace ConferenceManager.Models.Entities
{
    public class Presentation : Event
    {
        public int AttendeeID { get; set; }
        public Attendee Attendee { get; set; } // for presenter
    }
}
