namespace ConferenceManager.Models.Entities
{
    public class EventAttendee
    {
        public int EventID { get; set; }
        public int AttendeeID { get; set; }

        public virtual Event Event { get; set; }
        public virtual Attendee Attendee { get; set; }
    }
}
