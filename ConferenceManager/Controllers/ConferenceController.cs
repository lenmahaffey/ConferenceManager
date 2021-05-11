using ConferenceManager.Models.Entities;
using ConferenceManager.Services.DataAccess;
using ConferenceManager.Services.DataAccess.Interfaces;
using ConferenceManager.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace ConferenceManager.Controllers
{
    public class ConferenceController : Controller
    {
        private IConferenceManagerUnit context;
        private ISession session { get; set; }

        public ConferenceController(IConferenceManagerUnit ctx, IHttpContextAccessor accessor)
        {
            context = ctx;
            session = accessor.HttpContext.Session;
        }

        //Dashboard view for all conferences
        [Route("[controller]s/dashboard")]
        [HttpGet]
        public ViewResult Dashboard()
        {
            var c = context.Conferences.List(new QueryOptions<Conference>
            {
                OrderBy = c => c.Name
            });
            return View(c);
        }

        //View details of one conference
        [Route("[controller]/view")]
        public ViewResult ViewConference(int conferenceID)
        {
            IEnumerable<ConferenceVenue> tempV = context.ConferenceVenues.List(new QueryOptions<ConferenceVenue>
            {
                Where = cv => cv.ConferenceID == conferenceID
            });

            IEnumerable<ConferenceAttendee> tempA = context.ConferenceAttendees.List(new QueryOptions<ConferenceAttendee>
            {
                Where = ca => ca.ConferenceID == conferenceID
            });

            IEnumerable<Venue> v = from i in tempV select i.Venue;
            IEnumerable<Attendee> a = from i in tempA select i.Attendee;


            ConferenceViewModel model = new ConferenceViewModel()
            {
                Conference = context.Conferences.Get(conferenceID),
                Venues = v,
                Attendees = a
            };
            return View(model);
        }

        //List all conferences in database
        [Route("[controller]s")]
        public ViewResult ListConferences()
        {
            IEnumerable<Conference> c = context.Conferences.List();
            return View(c);
        }


        //Delete a conference. not implemented in views due to database concerns (cascading deletes untested)
        [Route("[controller]/delete")]
        [HttpGet]
        public ViewResult DeleteConference(int conferenceID)
        {
            var c = context.Conferences.Get(conferenceID);
            return View(c);
        }

        //Delete a conference. not implemented in views due to database concerns (cascading deletes untested)
        [HttpPost]
        public RedirectToActionResult DeleteConference(Conference conference)
        {
            context.Conferences.Delete(conference);
            context.SaveChanges();
            TempData["message"] = conference.Name + " was deleted";
            return RedirectToAction("ListConferences");
        }

        [Route("[controller]/edit")]
        [HttpGet]
        public ViewResult EditConference(int conferenceID)
        {
            var a = context.Conferences.Get(conferenceID);
            return View(a);
        }

        [Route("[controller]/add")]
        [HttpGet]
        public ViewResult AddConference()
        {
            return View(new Conference());
        }

        [HttpPost]
        public IActionResult SaveConference(Conference conference)
        {
            if (ModelState.IsValid)
            {
                if (conference.ID == 0)
                {
                    context.Conferences.Insert(conference);
                    TempData["message"] = conference.Name + " was added";
                }
                else
                {
                    context.Conferences.Update(conference);
                    TempData["message"] = conference.Name + " was updated";
                }
                context.SaveChanges();
                return RedirectToAction("ListConferences");
            }
            else
            {
                return View(conference);
            }
        }
    }
}
