using ConferenceManager.Models.Entities;
using ConferenceManager.Services.DataAccess.Interfaces;
using ConferenceManager.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ConferenceManager.Controllers
{
    [Authorize(Roles = "admin")]
    public class RoomController : Controller
    {
        private IConferenceManagerUnit context;
        private ISession session { get; set; }

        public RoomController(IConferenceManagerUnit ctx, IHttpContextAccessor accessor)
        {
            context = ctx;
            session = accessor.HttpContext.Session;
        }

        [Route("[controller]s")]
        public ViewResult ListRooms()
        {
            IEnumerable<Room> r = context.Rooms.List();
            return View(r);
        }

        [Route("[controller]/delete")]
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
            TempData["message"] = room.Name + "was deleted";
            return RedirectToAction("ListRooms");
        }

        [Route("[controller]/edit")]
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

        [Route("[controller]/add")]
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

        [Route("[controller]/save")]
        [HttpPost]
        public IActionResult SaveRoom(Room Room)
        {
            if (Room.ID == 0)
            {
                context.Rooms.Insert(Room);
                context.SaveChanges();
                TempData["message"] = Room.Name + "was added to " + Room.Venue.Name;
            }
            else
            {
                context.Rooms.Update(Room);
                context.SaveChanges();
                TempData["message"] = Room.Name + "was updated";
            }
            return RedirectToAction("ListRooms");
        }

        [Route("[controller]/view")]
        public ViewResult ViewRoom(int id)
        {
            var r = context.Rooms.Get(id);
            return View(r);
        }
    }
}
