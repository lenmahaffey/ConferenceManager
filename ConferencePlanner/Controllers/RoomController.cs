using ConferenceManager.Models.Entities;
using ConferenceManager.Services.DataAccess;
using ConferenceManager.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ConferenceManager.Controllers
{
    public class RoomController : Controller
    {
        private readonly ConferenceManagerUnit context;

        public RoomController(ConferenceManagerContext ctx)
        {
            context = new ConferenceManagerUnit(ctx);
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
            if (Room.RoomID == 0)
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
