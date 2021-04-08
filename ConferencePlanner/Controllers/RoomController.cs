using ConferenceManager.Models.Entities;
using ConferenceManager.Services.DataAccess.Interfaces;
using ConferenceManager.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ConferenceManager.Controllers
{
    public class RoomController : Controller
    {
        private readonly IConferenceManagerUnit context;

        public RoomController(IConferenceManagerUnit ctx)
        {
            context = ctx;
        }

        public ViewResult ListRooms()
        {
            IEnumerable<Room> r = context.Rooms.List();
            return View(r);
        }

        [HttpGet]
        public ViewResult DeleteRoom(int id)
        {
            var r = context.Rooms.Get(id);
            return View(r);
        }

        [HttpPost]
        public RedirectToActionResult DeleteRoom(Room room)
        {
            context.Rooms.Delete(room);
            context.SaveChanges();
            return RedirectToAction("ListRooms");
        }

        [HttpGet]
        public ViewResult EditRoom(int id)
        {
            Room r = context.Rooms.Get(id);
            var model = new RoomViewModel
            {
                Room = r,
                Venue = context.Venues.Get(r.VenueID),
                Venues = context.Venues.List()
            };
            return View(model);
        }

        [HttpGet]
        public ViewResult AddRoom()
        {
            var model = new RoomViewModel
            {
                Room = new Room(),
                Venue = new Venue(),
                Venues = context.Venues.List()
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult SaveRoom(Room Room)
        {
            if (Room.ID == 0)
            {
                context.Rooms.Insert(Room);
                context.SaveChanges();
            }
            else
            {
                context.Rooms.Update(Room);
                context.SaveChanges();
            }
            return RedirectToAction("ListRooms");
        }
    }
}
