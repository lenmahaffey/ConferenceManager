﻿using ConferencePlanner.Models;
using ConferencePlanner.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConferencePlanner.Controllers
{
    public class AttendeeController : Controller
    {
        private readonly IConferencePlannerData context;

        public AttendeeController(IConferencePlannerData ctx)
        {
            context = ctx;
        }

        public ViewResult ListAttendees()
        {
            IEnumerable<Attendee> a = context.GetAttendees();
            return View(a);
        }

        [HttpGet]
        public IActionResult DeleteAttendee(int id)
        {
            var attendee = context.GetAttendee(id);
            return View(attendee);
        }

        [HttpPost]
        public IActionResult DeleteAttendee(Attendee attendee)
        {
            context.DeleteAttendee(attendee);
            return RedirectToAction("ListAttendees");
        }

        [HttpGet]
        public ViewResult EditAttendee(int id)
        {
            var a = context.GetAttendee(id);
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
            if (attendee.AttendeeID == 0)
            {
                context.AddAttendee(attendee);
            }
            else
            {
                context.EditAttendee(attendee);
            }
            return RedirectToAction("ListAttendees");
        }
    }
}
