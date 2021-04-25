using ConferenceManager.Models.Entities;
using ConferenceManager.Services.DataAccess;
using ConferenceManager.Services.DataAccess.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ConferenceManager.Controllers
{
    public class AttendeeController : Controller
    {
        private IConferenceManagerRepository<Attendee> context;

        public AttendeeController(IConferenceManagerRepository<Attendee> ctx)
        {
            context = ctx;
        }

        public ViewResult ListAttendees()
        {
            var attendees = context.List(new QueryOptions<Attendee>
            {
                OrderBy = a => a.LastName
            });
            return View(attendees);
        }

        [HttpGet]
        public IActionResult DeleteAttendee(int id)
        {
            var attendee = context.Get(id);
            return View(attendee);
        }

        [HttpPost]
        public IActionResult DeleteAttendee(Attendee attendee)
        {
            context.Delete(attendee);
            context.Save();
            return RedirectToAction("ListAttendees");
        }

        [HttpGet]
        public ViewResult EditAttendee(int id)
        {
            var a = context.Get(id);
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
            string message;
            if (ModelState.IsValid)
            {
                if (attendee.ID == 0)
                {
                    context.Insert(attendee);
                    message = attendee.FullName + " was added.";
                }
                else
                {
                    context.Update(attendee);
                    message = attendee.FullName + " was updated.";
                }
                context.Save();
                TempData["message"] = message;
                return RedirectToAction("ListAttendees");
            }
            else
            {
                return View(attendee);
            }
        }

        public ViewResult ViewAttendee(int id)
        {
            var a = context.Get(id);
            return View(a);
        }
    }
}
