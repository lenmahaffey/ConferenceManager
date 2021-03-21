//using ConferencePlanner.Models;
using ConferencePlanner.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ConferencePlanner.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConferencePlannerData context;

        public HomeController(IConferencePlannerData ctx)
        {
            context = ctx;
        }
        public IActionResult Index()
        {
            var conferences = context.GetConferences();
            return View(conferences);
        }
    }
}
