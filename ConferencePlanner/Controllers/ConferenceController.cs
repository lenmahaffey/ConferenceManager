using ConferencePlanner.Models;
using ConferencePlanner.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConferencePlanner.Controllers
{
    public class ConferenceController : Controller
    {
        private readonly IConferencePlannerData context;

        public ConferenceController(IConferencePlannerData ctx)
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
    }
}
