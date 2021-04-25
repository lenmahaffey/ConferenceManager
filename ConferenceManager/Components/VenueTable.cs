using ConferenceManager.Models.Entities;
using ConferenceManager.Services.DataAccess;
using ConferenceManager.Services.DataAccess.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConferenceManager.Components
{
    public class VenueTable : ViewComponent
    {
        private IConferenceManagerRepository<Venue> data { get; set; }

        public VenueTable(IConferenceManagerRepository<Venue> rep)
        {
            data = rep;
        }
        public IViewComponentResult Invoke()
        {
            var conferences = data.List(new QueryOptions<Venue>
            {
                OrderBy = ca => ca.Name
            });
            return View(VenueOptions.Path, conferences);
        }
    }
}
