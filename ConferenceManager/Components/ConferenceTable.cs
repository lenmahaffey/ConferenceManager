using ConferenceManager.Models.Entities;
using ConferenceManager.Services.DataAccess;
using ConferenceManager.Services.DataAccess.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ConferenceManager.Components
{
    public class ConferenceTable : ViewComponent
    {
        private IConferenceManagerUnit data { get; set; }

        public ConferenceTable(IConferenceManagerUnit  unit)
        {
            data = unit;
        }
        public IViewComponentResult Invoke()
        {
            var conferences = data.Conferences.List(new QueryOptions<Conference>
            {
                OrderBy = ca => ca.Name
            });
            return View(ConferenceOptions.Path, conferences);
        }
    }
}
