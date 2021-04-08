using ConferenceManager.Models.Entities;
using ConferenceManager.Services.DataAccess.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ConferenceManager.Controllers
{
    public class VenueController : Controller
    {
        private IConferenceManagerUnit context;

        public VenueController(IConferenceManagerUnit ctx)
        {
            context = ctx;
        }

        public ViewResult ListVenues()
        {
            var v = context.Venues.List();
            return View(v);
        }

        [HttpGet]
        public ViewResult DeleteVenue(int id)
        {
            var v = context.Venues.Get(id);
            return View(v);
        }

        [HttpPost]
        public RedirectToActionResult DeleteVenue(Venue venue)
        {
            context.Venues.Delete(venue);
            context.SaveChanges();
            return RedirectToAction("ListVenues");
        }

        [HttpGet]
        public ViewResult EditVenue(int id)
        {
            var a = context.Venues.Get(id);
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
            if (Venue.ID == 0)
            {
                context.Venues.Insert(Venue);
                context.SaveChanges();
            }
            else
            {
                context.Venues.Update(Venue);
                context.SaveChanges();
            }
            return RedirectToAction("ListVenues");
        }
    }
}
