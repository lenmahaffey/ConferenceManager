using ConferenceManager.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

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
