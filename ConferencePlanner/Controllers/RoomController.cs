using ConferencePlanner.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConferencePlanner.Controllers
{
    public class RoomController : Controller
    {
        private readonly IConferencePlannerData context;

        public RoomController(IConferencePlannerData ctx)
        {
            context = ctx;
        }

        public ViewResult ListRooms()
        {
            var r = context.GetRooms();
            return View(r);
        }
    }
}
