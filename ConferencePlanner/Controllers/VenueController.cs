using ConferencePlanner.Models;
using ConferencePlanner.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConferencePlanner.Controllers
{
    public class VenueController : Controller
    {
        private readonly IConferencePlannerData context;

        public VenueController(IConferencePlannerData ctx)
        {
            context = ctx;
        }

        public ViewResult ListVenues()
        {
            var v = context.GetVenues();
            return View(v);
        }

        [HttpGet]
        public ViewResult DeleteVenue(int id)
        {
            var v = context.GetVenue(id);
            return View(v);
        }

        [HttpPost]
        public RedirectToActionResult DeleteVenue(Venue venue)
        {
            context.DeleteVenue(venue);
            return RedirectToAction("ListVenues");
        }

        [HttpGet]
        public ViewResult EditVenue(int id)
        {
            var a = context.GetVenue(id);
            return View(a);
        }

        [HttpGet]
        public ViewResult AddVenue()
        {
            return View(new Venue());
        }

        [HttpPost]
        public IActionResult SaveVenue(Venue Venue)
        {
            if (Venue.VenueID == 0)
            {
                context.AddVenue(Venue);
            }
            else
            {
                context.EditVenue(Venue);
            }
            return RedirectToAction("ListVenues");
        }
    }
}
