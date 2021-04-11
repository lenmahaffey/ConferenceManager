namespace ConferenceManager.Models.Entities
{
    public class ConferenceAttendee
    {
        public int ConferenceID { get; set; }
        public int AttendeeID { get; set; }

        public virtual Conference Conference { get; set; }
        public virtual Attendee Attendee { get; set; }
    }
}
