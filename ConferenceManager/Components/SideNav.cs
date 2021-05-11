using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using ConferenceManager.Models.Entities;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ConferenceManager.Components
{
    public class SideNav : ViewComponent
    {
        private SignInManager<User> signInManager;
        private ClaimsPrincipal currentUser => ViewContext?.HttpContext?.User;
        public SideNav(SignInManager<User> sm)
        {
            signInManager = sm;
        }

        public IViewComponentResult Invoke()
        {
            if (signInManager.IsSignedIn(currentUser) && currentUser.IsInRole("admin"))
            {
                return View(SideNavOptions.Path);
            }
            else
            {
                return Content(string.Empty);
            }
        }
    }
}
