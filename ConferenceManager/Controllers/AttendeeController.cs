using ConferenceManager.Models.Entities;
using ConferenceManager.Services.DataAccess;
using ConferenceManager.Services.DataAccess.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ConferenceManager.Controllers
{
    public class AttendeeController : Controller
    {
        private IConferenceManagerRepository<Attendee> context;
        private ISession session { get; set; }

        public AttendeeController(IConferenceManagerRepository<Attendee> ctx, IHttpContextAccessor accessor)
        {
            context = ctx;
            session = accessor.HttpContext.Session;
        }

        [Route("[controller]s")]
        public ViewResult ListAttendees()
        {
            var attendees = context.List(new QueryOptions<Attendee>
            {
                OrderBy = a => a.LastName
            });
            return View(attendees);
        }

        [Route("[controller]/delete")]
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

        [Route("[controller]/edit")]
        [HttpGet]
        public ViewResult EditAttendee(int id)
        {
            var a = context.Get(id);
            return View(a);
        }

        [Route("[controller]/add")]
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

        [Route("[controller]/view")]
        public ViewResult ViewAttendee(int id)
        {
            var a = context.Get(id);
            return View(a);
        }
    }
}
