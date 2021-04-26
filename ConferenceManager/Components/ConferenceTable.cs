using ConferenceManager.Models.Entities;
using ConferenceManager.Services.DataAccess;
using ConferenceManager.Services.DataAccess.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;

namespace ConferenceManager.Components
{
    public class ConferenceTable : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View(ConferenceOptions.Path);
        }
    }
}
