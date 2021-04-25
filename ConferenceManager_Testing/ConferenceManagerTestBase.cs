using ConferenceManager.Models.Entities;
using ConferenceManager.Services.DataAccess;
using ConferenceManager.Services.DataAccess.Interfaces;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Moq;
using System.Collections.Generic;

namespace ConferenceManager.Testing
{
    public class ConferenceManagerTestBase
    {
        protected Mock<ITempDataDictionary> mockHttpContext { get; }
        protected Mock<IConferenceManagerUnit> mockUnit {get; }
        protected Mock<IConferenceManagerRepository<Attendee>> attendees { get; }
        protected Mock<IConferenceManagerRepository<Conference>> conferences { get; }
        protected Mock<IConferenceManagerRepository<Presentation>> presentations { get; }
        protected Mock<IConferenceManagerRepository<Venue>> venues { get; }
        protected Mock<IConferenceManagerRepository<Room>> rooms { get; }

        public ConferenceManagerTestBase()
        {
            mockHttpContext = new Mock<ITempDataDictionary>();
            attendees = new Mock<IConferenceManagerRepository<Attendee>>();
            conferences = new Mock<IConferenceManagerRepository<Conference>>();
            presentations = new Mock<IConferenceManagerRepository<Presentation>>();
            rooms = new Mock<IConferenceManagerRepository<Room>>();
            venues = new Mock<IConferenceManagerRepository<Venue>>();
            mockUnit = new Mock<IConferenceManagerUnit>();
            SetUpUnitOfWork();
        }

        protected void SetUpRepos()
        {
            attendees.Setup(m => m.Get(It.IsAny<int>())).Returns(new Attendee());
            attendees.Setup(m => m.Get(It.IsAny<QueryOptions<Attendee>>())).Returns(new Attendee());
            attendees.Setup(m => m.List(It.IsAny<QueryOptions<Attendee>>())).Returns(new List<Attendee>());

            conferences.Setup(m => m.Get(It.IsAny<int>())).Returns(new Conference());
            conferences.Setup(m => m.Get(It.IsAny<QueryOptions<Conference>>())).Returns(new Conference());
            conferences.Setup(m => m.List(It.IsAny<QueryOptions<Conference>>())).Returns(new List<Conference>());

            presentations.Setup(m => m.Get(It.IsAny<int>())).Returns(new Presentation());
            presentations.Setup(m => m.Get(It.IsAny<QueryOptions<Presentation>>())).Returns(new Presentation());
            presentations.Setup(m => m.List(It.IsAny<QueryOptions<Presentation>>())).Returns(new List<Presentation>());

            rooms.Setup(m => m.Get(It.IsAny<int>())).Returns(new Room());
            rooms.Setup(m => m.Get(It.IsAny<QueryOptions<Room>>())).Returns(new Room());
            rooms.Setup(m => m.List(It.IsAny<QueryOptions<Room>>())).Returns(new List<Room>());

            venues.Setup(m => m.Get(It.IsAny<int>())).Returns(new Venue());
            venues.Setup(m => m.Get(It.IsAny<QueryOptions<Venue>>())).Returns(new Venue());
            venues.Setup(m => m.List(It.IsAny<QueryOptions<Venue>>())).Returns(new List<Venue>());
        }
        protected void SetUpUnitOfWork()
        {
            SetUpRepos();
            mockUnit.Setup(m => m.Attendees).Returns(attendees.Object);
            mockUnit.Setup(m => m.Conferences).Returns(conferences.Object);
            mockUnit.Setup(m => m.Presentations).Returns(presentations.Object);
            mockUnit.Setup(m => m.Rooms).Returns(rooms.Object);
            mockUnit.Setup(m => m.Venues).Returns(venues.Object);
        }
    }
}
