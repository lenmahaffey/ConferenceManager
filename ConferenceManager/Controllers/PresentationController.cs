using ConferenceManager.Models.Entities;
using ConferenceManager.Services.DataAccess.Interfaces;
using ConferenceManager.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConferenceManager.Controllers
{
    public class PresentationController : Controller
    {
        private IConferenceManagerUnit context;
        private ISession session { get; set; }

        public PresentationController(IConferenceManagerUnit ctx, IHttpContextAccessor accessor)
        {
            context = ctx;
            session = accessor.HttpContext.Session;
        }

        [Route("[controller]s")]
        public ViewResult ListPresentations()
        {
            var p = context.Presentations.List();
            return View(p);
        }

        [Route("[controller]/delete")]
        [HttpGet]
        public ViewResult DeletePresentation(int id)
        {
            Presentation p = context.Presentations.Get(id);
            return View(p);
        }

        [HttpPost]
        public RedirectToActionResult DeletePresentation(Presentation presentation)
        {
            context.Presentations.Delete(presentation);
            context.SaveChanges();
            TempData["message"] = presentation.Name + "was removed from the database";
            return RedirectToAction("ListPresentations");
        }

        [Route("[controller]/edit")]
        [HttpGet]
        public ViewResult EditPresentation(int id)
        {
            Presentation p = context.Presentations.Get(id);
            var model = new PresentationViewModel
            {
                Presentation = p,
                Attendee = context.Attendees.Get(p.PresenterID),
                Conference = context.Conferences.Get(p.ConferenceID),
                Room = context.Rooms.Get(p.RoomID),
                Attendees = context.Attendees.List(),
                Conferences = context.Conferences.List(),
                Rooms = context.Rooms.List()
            };
            return View(model);
        }

        [Route("[controller]/add")]
        [HttpGet]
        public ViewResult AddPresentation()
        {
            var model = new PresentationViewModel
            {
                Presentation = new Presentation(),
                Attendee = new Attendee(),
                Conference = new Conference(),
                Room = new Room(),
                Attendees = context.Attendees.List(),
                Conferences = context.Conferences.List(),
                Rooms = context.Rooms.List()
            };
            return View(model);
        }

        [Route("[controller]/save")]
        [HttpPost]
        public IActionResult SavePresentation(Presentation presentation)
        {
            if (presentation.ID == 0)
            {
                context.Presentations.Insert(presentation);
                context.SaveChanges();
                TempData["message"] = presentation.Name + " was added to " + presentation.Conference.Name;
            }
            else
            {
                context.Presentations.Update(presentation);
                context.SaveChanges();
                TempData["message"] = presentation.Name + " was added to updated";
            }
            return RedirectToAction("ListPresentations");
        }
        public ViewResult ViewPresentation(int id)
        {
            var p = context.Presentations.Get(id);
            return View(p);
        }
    }
}
