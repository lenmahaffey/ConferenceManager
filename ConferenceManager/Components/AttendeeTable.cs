using ConferenceManager.Services.DataAccess.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConferenceManager.Components
{
    public class AttendeeTable : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View(AttendeeOptions.Path);
        }
    }
}
