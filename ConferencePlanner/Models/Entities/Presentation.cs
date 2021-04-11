using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ConferenceManager.Models.Entities
{
    public class Presentation : Event
    {
        public int PresenterID { get; set; }
        public virtual Presenter Presenter { get; set; }

    }
}
