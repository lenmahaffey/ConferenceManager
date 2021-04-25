using ConferenceManager.Models.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

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
