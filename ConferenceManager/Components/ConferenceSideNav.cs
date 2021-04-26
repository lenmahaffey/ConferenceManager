using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConferenceManager.Components
{
    public class ConferenceSideNav : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View(ConferenceSideNavOptions.Path);
        }
    }
}
