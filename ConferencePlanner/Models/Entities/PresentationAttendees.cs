namespace ConferenceManager.Models
{
    public class PresentationAttendees
    {
        public int PresentationID { get; set; }
        public int AttendeeID { get; set; }

        public Presentation Presentation { get; set; }
        public Attendee Attendee { get; set; }
    }
}
