//using ConferenceManager.Models;
using ConferenceManager.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ConferenceManager.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConferenceManagerData context;

        public HomeController(IConferenceManagerData ctx)
        {
            context = ctx;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
