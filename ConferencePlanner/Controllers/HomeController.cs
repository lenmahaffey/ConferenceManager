using ConferenceManager.Services.DataAccess;
using Microsoft.AspNetCore.Mvc;

namespace ConferenceManager.Controllers
{
    public class HomeController : Controller
    {
        private readonly ConferenceManagerUnit context;

        public HomeController(ConferenceManagerContext ctx)
        {
            context = new ConferenceManagerUnit(ctx);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
