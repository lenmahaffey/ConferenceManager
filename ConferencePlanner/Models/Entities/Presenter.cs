using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConferenceManager.Models.Entities
{
    public class Presenter : Attendee
    {
        public virtual ICollection<Presentation> Presentations { get; set; }
    }
}
