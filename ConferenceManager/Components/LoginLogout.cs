using ConferenceManager.Models.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace ConferenceManager.Components
{
    public class LoginLogout : ViewComponent
    {
        private SignInManager<User> signInManager;
        public LoginLogout(SignInManager<User> mgr)
        {
            signInManager = mgr;
        }

        public IViewComponentResult Invoke(ClaimsPrincipal user)
        {
            if (signInManager.IsSignedIn(user))
            {
                return View(LoginLogOutOptions.Path, true);
            }
            else
            {
                return View(LoginLogOutOptions.Path, false);
            }
        }
    }
}
