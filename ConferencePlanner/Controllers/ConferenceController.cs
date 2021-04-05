using ConferenceManager.Models;
using ConferenceManager.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ConferenceManager.Controllers
{
    public class ConferenceController : Controller
    {
        private readonly IConferenceManagerData context;

        public ConferenceController(IConferenceManagerData ctx)
        {
            context = ctx;
        }
        public ViewResult ListConferences()
        {
            var c = context.GetConferences();
            return View(c);
        }

        [HttpGet]
        public ViewResult DeleteConference(int id)
        {
            var c = context.GetConference(id);
            return View(c);
        }

        [HttpPost]
        public RedirectToActionResult DeleteConference(Conference conference)
        {
            context.DeleteConference(conference);
            return RedirectToAction("ListConferences");
        }

        [HttpGet]
        public ViewResult EditConference(int id)
        {
            var a = context.GetConference(id);
            return View(a);
        }

        [HttpGet]
        public ViewResult AddConference()
        {
            return View(new Conference());
        }

        [HttpPost]
        public IActionResult SaveConference(Conference conference)
        {
            if (conference.ConferenceID == 0)
            {
                context.AddConference(conference);
            }
            else
            {
                context.EditConference(conference);
            }
            return RedirectToAction("ListConferences");
        }
    }
}
