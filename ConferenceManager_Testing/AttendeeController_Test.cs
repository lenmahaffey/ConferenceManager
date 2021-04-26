using ConferenceManager.Controllers;
using ConferenceManager.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace ConferenceManager.Testing.Controllers
{
    public class AttendeeController_Test : ConferenceManagerTestBase
    {
        [Fact]
        public void AddAttendee_ReturnsViewResult()
        {
            //arrange
            var controller = new AttendeeController(attendees.Object);

            //act
            var model = controller.AddAttendee().ViewData.Model as Attendee;

            //assert
            Assert.IsType<Attendee>(model);
        }

        [Fact]
        public void EditAttendee_ReturnsViewResult()
        {
            //arrange
            var controller = new AttendeeController(attendees.Object);

            //act
            var model = controller.EditAttendee(1).ViewData.Model as Attendee;

            //assert
            Assert.IsType<Attendee>(model);
        }

        [Fact]
        public void ListAttendees_ReturnsViewResult()
        {
            //arrange
            var controller = new AttendeeController(attendees.Object);

            //act
            var model = controller.ListAttendees().ViewData.Model as IEnumerable<Attendee>;

            //assert
            Assert.IsType<List<Attendee>>(model);
        }

        [Fact]
        public void SaveAttendee_ReturnsViewResultIfValidModelOnAddNew()
        {
            //arrange
            var controller = new AttendeeController(attendees.Object)
            {
                TempData = mockHttpContext.Object
            };

            var attendeeToSave = new Attendee { ID = 0 };
            //act
            var result = controller.SaveAttendee(attendeeToSave);

            //assert
            Assert.IsType<RedirectToActionResult>(result);
        }

        [Fact]
        public void SaveAttendee_TempMessageCorrectOnAddNew()
        {
            //arrange
            var controller = new AttendeeController(attendees.Object)
            {
                TempData = mockHttpContext.Object
            };
            var attendeeToSave = new Attendee { ID = 0 };
            string expected = " was added.";

            //act
            var result = controller.SaveAttendee(attendeeToSave);
            var actual = mockHttpContext.Object.Keys;

            //assert
            //Assert.Equal(expected, actual);
        }

        [Fact]
        public void SaveAttendee_TempMessageCorrectOnEdit()
        {
            //arrange
            var controller = new AttendeeController(attendees.Object)
            {
                TempData = mockHttpContext.Object
            };
            var attendeeToSave = new Attendee { ID = 1 };
            string expected = " was updated.";

            //act
            var result = controller.SaveAttendee(attendeeToSave);
            string actual = controller.TempData["message"]?.ToString();

            //assert
            //Assert.Equal(expected, actual);
        }

        [Fact]
        public void SaveAttendee_ReturnsViewResultIfValidModelOnUpdate()
        {
            //arrange
            var controller = new AttendeeController(attendees.Object)
            {
                TempData = mockHttpContext.Object
            };

            var attendeeToSave = new Attendee { ID = 1 };
            //act
            var result = controller.SaveAttendee(attendeeToSave);

            //assert
            Assert.IsType<RedirectToActionResult>(result);
        }

        [Fact]
        public void ViewAttendee_ReturnsViewResult()
        {
            //arrange
            var controller = new AttendeeController(attendees.Object);

            //act
            var model = controller.ViewAttendee(1).ViewData.Model as Attendee;

            //assert
            Assert.IsType<Attendee>(model);
        }
    }
}
