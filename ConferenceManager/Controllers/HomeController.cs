using ConferenceManager.Services.DataAccess.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ConferenceManager.Controllers
{
    public class HomeController : Controller
    {
        private IConferenceManagerUnit context;

        public HomeController(IConferenceManagerUnit ctx)
        {
            context = ctx;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
