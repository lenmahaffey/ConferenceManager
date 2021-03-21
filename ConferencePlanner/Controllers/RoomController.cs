using ConferenceManager.Models;
using ConferenceManager.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConferenceManager.Controllers
{
    public class RoomController : Controller
    {
        private readonly IConferenceManagerData context;

        public RoomController(IConferenceManagerData ctx)
        {
            context = ctx;
        }

        public ViewResult ListRooms()
        {
            var r = context.GetRooms();
            return View(r);
        }

        [HttpGet]
        public ViewResult DeleteRoom(int id)
        {
            var r = context.GetRoom(id);
            return View(r);
        }

        [HttpPost]
        public RedirectToActionResult DeleteRoom(Room room)
        {
            context.DeleteRoom(room);
            return RedirectToAction("ListRooms");
        }
    }
}
