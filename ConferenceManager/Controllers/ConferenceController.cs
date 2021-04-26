using ConferenceManager.Models.Entities;
using ConferenceManager.Services.DataAccess;
using ConferenceManager.Services.DataAccess.Interfaces;
using ConferenceManager.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace ConferenceManager.Controllers
{
    public class ConferenceController : Controller
    {
        private IConferenceManagerUnit context;

        public ConferenceController(IConferenceManagerUnit ctx)
        {
            context = ctx;
        }

        //Dashboard view for all conferences
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
        public ViewResult ViewConference(int conferenceID)
        {
            ConferenceViewModel model = new ConferenceViewModel()
            {
                Conference = context.Conferences.Get(conferenceID),
                Venues = context.ConferenceVenues.List(new QueryOptions<ConferenceVenue>
                {
                    Where = cv => cv.ConferenceID == conferenceID
                }),
                Attendees = context.ConferenceAttendees.List(new QueryOptions<ConferenceAttendee>
                {
                    Where = ca => ca.ConferenceID == conferenceID
                })
            };
            return View(model);
        }

        //List all conferences in database
        public ViewResult ListConferences()
        {
            IEnumerable<Conference> c = context.Conferences.List();
            return View(c);
        }


        //Delete a conference by ID. not implemented in views
        [HttpGet]
        public ViewResult DeleteConference(int conferenceID)
        {
            var c = context.Conferences.Get(conferenceID);
            return View(c);
        }

        //Delete a conference. not implemented in views
        [HttpPost]
        public RedirectToActionResult DeleteConference(Conference conference)
        {
            context.Conferences.Delete(conference);
            context.SaveChanges();
            return RedirectToAction("ListConferences");
        }


        [HttpGet]
        public ViewResult EditConference(int conferenceID)
        {
            var a = context.Conferences.Get(conferenceID);
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
            string message;
            if (ModelState.IsValid)
            {
                if (conference.ID == 0)
                {
                    message = conference.Name + " was added.";
                    context.Conferences.Insert(conference);
                }
                else
                {
                    message = conference.Name + " was updated.";
                    context.Conferences.Update(conference);
                }
                TempData["message"] = message;
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
