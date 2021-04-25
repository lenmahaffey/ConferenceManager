using Microsoft.AspNetCore.Mvc;
using System;

namespace ConferenceManager.Components
{
    public class Copyright : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            int currentYear = DateTime.Today.Year;
            return View(CopyrightOptions.Path, currentYear);
        }
    }
}
