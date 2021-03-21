﻿using ConferencePlanner.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConferencePlanner.Controllers
{
    public class PresentationController : Controller
    {
        private readonly IConferencePlannerData context;

        public PresentationController(IConferencePlannerData ctx)
        {
            context = ctx;
        }

        public ViewResult ListPresentations()
        {
            var p = context.GetPresentations();
            return View(p);
        }
    }
}