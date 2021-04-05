namespace ConferenceManager.Models.Entities
{
    public class ConferenceAttendees
    {
        public int ConferenceID { get; set; }
        public int AttendeeID { get; set; }

        public Conference Conference { get; set; }
        public Attendee Attendee { get; set; }
    }
}
