using ConferenceManager.Models;
using ConferenceManager.Services.Interfaces;
using ConferenceManager.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConferenceManager.Controllers
{
    public class PresentationController : Controller
    {
        private readonly IConferenceManagerData context;

        public PresentationController(IConferenceManagerData ctx)
        {
            context = ctx;
        }

        public ViewResult ListPresentations()
        {
            var p = context.GetPresentations();
            return View(p);
        }

        [HttpGet]
        public ViewResult DeletePresentation(int id)
        {
            Presentation p = context.GetPresentation(id);
            return View(p);
        }

        [HttpPost]
        public RedirectToActionResult DeletePresentation(Presentation presentation)
        {
            context.DeletePresentation(presentation);
            return RedirectToAction("ListPresentations");
        }

        [HttpGet]
        public ViewResult EditPresentation(int id)
        {
            Presentation p = context.GetPresentation(id);
            var model = new PresentationViewModel
            {
                Presentation = p,
                Attendee = context.GetAttendee(p.AttendeeID),
                Conference = context.GetConference(p.ConferenceID),
                Room = context.GetRoom(p.RoomID),
                Attendees = context.GetAttendees(),
                Conferences = context.GetConferences(),
                Rooms = context.GetRooms()
            };
            return View(model);
        }

        [HttpGet]
        public ViewResult AddPresentation()
        {
            var model = new PresentationViewModel
            {
                Presentation = new Presentation(),
                Attendee = new Attendee(),
                Conference = new Conference(),
                Room = new Room(),
                Attendees = context.GetAttendees(),
                Conferences = context.GetConferences(),
                Rooms = context.GetRooms()
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult SavePresentation(Presentation presentation)
        {
            if (presentation.PresentationID == 0)
            {
                context.AddPresentation(presentation);
            }
            else
            {
                context.EditPresentation(presentation);
            }
            return RedirectToAction("ListPresentations");
        }
    }
}
