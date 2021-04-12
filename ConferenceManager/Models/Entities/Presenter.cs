using System.Collections.Generic;

namespace ConferenceManager.Models.Entities
{
    public class Presenter : Attendee
    {
        public virtual ICollection<Presentation> Presentations { get; set; }
    }
}
