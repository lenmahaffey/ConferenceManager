using ConferencePlanner.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConferencePlanner.Controllers
{
    public class VenueController : Controller
    {
        private readonly IConferencePlannerData context;

        public VenueController(IConferencePlannerData ctx)
        {
            context = ctx;
        }

        public ViewResult ListVenues()
        {
            var v = context.GetVenues();
            return View(v);
        }
    }
}
