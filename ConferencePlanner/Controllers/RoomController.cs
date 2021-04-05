using ConferenceManager.Models;
using ConferenceManager.Services.Interfaces;
using ConferenceManager.ViewModels;
using Microsoft.AspNetCore.Mvc;

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

        [HttpGet]
        public ViewResult EditRoom(int id)
        {
            Room r = context.GetRoom(id);
            var model = new RoomViewModel
            {
                Room = r,
                Venue = context.GetVenue(r.VenueID),
                Venues = context.GetVenues()
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
                Venues = context.GetVenues()
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult SaveRoom(Room Room)
        {
            if (Room.RoomID == 0)
            {
                context.AddRoom(Room);
            }
            else
            {
                context.EditRoom(Room);
            }
            return RedirectToAction("ListRooms");
        }
    }
}
