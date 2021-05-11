using ConferenceManager.Models.Entities;
using ConferenceManager.Services.DataAccess.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConferenceManager.Controllers
{
    [Authorize(Roles = "admin")]
    public class VenueController : Controller
    {
        private IConferenceManagerUnit context;
        private ISession session { get; set; }

        public VenueController(IConferenceManagerUnit ctx, IHttpContextAccessor accessor)
        {
            context = ctx;
            session = accessor.HttpContext.Session;
        }

        [Route("[controller]s")]
        public ViewResult ListVenues()
        {
            var v = context.Venues.List();
            return View(v);
        }

        [Route("[controller]/delete")]
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
            TempData["message"] = venue.Name + "was deleted";
            return RedirectToAction("ListVenues");
        }

        [Route("[controller]/edit")]
        [HttpGet]
        public ViewResult EditVenue(int id)
        {
            var a = context.Venues.Get(id);
            return View(a);
        }

        [Route("[controller]/add")]
        [HttpGet]
        public ViewResult AddVenue()
        {
            return View(new Venue());
        }


        [HttpPost]
        public IActionResult SaveVenue(Venue venue)
        {
            if (venue.ID == 0)
            {
                context.Venues.Insert(venue);
                context.SaveChanges();
                TempData["message"] = venue.Name + "was saved";
            }
            else
            {
                context.Venues.Update(venue);
                context.SaveChanges();
                TempData["message"] = venue.Name + "was updated";
            }
            return RedirectToAction("ListVenues");
        }

        [Route("[controller]/view")]
        public ViewResult ViewVenue(int id)
        {
            Venue v = context.Venues.Get(id);
            return View(v);
        }
    }
}
