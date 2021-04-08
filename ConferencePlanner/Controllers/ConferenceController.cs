using ConferenceManager.Models.Entities;
using ConferenceManager.Services.DataAccess.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ConferenceManager.Controllers
{
    public class ConferenceController : Controller
    {
        private IConferenceManagerUnit context;

        public ConferenceController(IConferenceManagerUnit ctx)
        {
            context = ctx;
        }
        public ViewResult ListConferences()
        {
            IEnumerable<Conference> c = context.Conferences.List();
            return View(c);
        }

        [HttpGet]
        public ViewResult DeleteConference(int id)
        {
            var c = context.Conferences.Get(id);
            return View(c);
        }

        [HttpPost]
        public RedirectToActionResult DeleteConference(Conference conference)
        {
            context.Conferences.Delete(conference);
            context.SaveChanges();
            return RedirectToAction("ListConferences");
        }

        [HttpGet]
        public ViewResult EditConference(int id)
        {
            var a = context.Conferences.Get(id);
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
            if (conference.ID == 0)
            {
                context.Conferences.Insert(conference);
                context.SaveChanges();
            }
            else
            {
                context.Conferences.Update(conference);
                context.SaveChanges();
            }
            return RedirectToAction("ListConferences");
        }
    }
}
