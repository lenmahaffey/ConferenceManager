using ConferenceManager.Models.Entities;
using ConferenceManager.Services.DataAccess.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ConferenceManager.Controllers
{
    public class AttendeeController : Controller
    {
        private IConferenceManagerUnit context;

        public AttendeeController(IConferenceManagerUnit ctx)
        {
            context = ctx;
        }

        public ViewResult ListAttendees()
        {
            IEnumerable<Attendee> a = context.Attendees.List();
            return View(a);
        }

        [HttpGet]
        public IActionResult DeleteAttendee(int id)
        {
            var attendee = context.Attendees.Get(id);
            return View(attendee);
        }

        [HttpPost]
        public IActionResult DeleteAttendee(Attendee attendee)
        {
            context.Attendees.Delete(attendee);
            context.SaveChanges();
            return RedirectToAction("ListAttendees");
        }

        [HttpGet]
        public ViewResult EditAttendee(int id)
        {
            var a = context.Attendees.Get(id);
            return View(a);
        }

        [HttpGet]
        public ViewResult AddAttendee()
        {
            return View(new Attendee());
        }

        [HttpPost]
        public IActionResult SaveAttendee(Attendee attendee)
        {
            if (attendee.ID == 0)
            {
                context.Attendees.Insert(attendee);
                context.SaveChanges();
            }
            else
            {
                context.Attendees.Update(attendee);
                context.SaveChanges();
            }
            return RedirectToAction("ListAttendees");
        }

        public ViewResult ViewAttendee(int id)
        {
            var a = context.Attendees.Get(id);
            return View(a);
        }
    }
}
