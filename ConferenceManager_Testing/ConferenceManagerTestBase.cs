using ConferenceManager.Models.Entities;
using ConferenceManager.Services.DataAccess;
using ConferenceManager.Services.DataAccess.Interfaces;
using Microsoft.EntityFrameworkCore;
using Moq;
using System.Collections.Generic;

namespace ConferenceManager.Testing
{
    public class ConferenceManagerTestBase
    {
        protected ConferenceManagerContext context { get; }
        protected ConferenceManagerUnit  unit { get; }
        protected Mock<IConferenceManagerUnit> mockUnit {get; }
        private Mock<IConferenceManagerRepository<Attendee>> attendees { get; }
        private Mock<IConferenceManagerRepository<Conference>> conferences { get; }
        private Mock<IConferenceManagerRepository<Presentation>> presentations { get; }
        private Mock<IConferenceManagerRepository<Venue>> venues { get; }
        private Mock<IConferenceManagerRepository<Room>> rooms { get; }

        public ConferenceManagerTestBase()
        {
            string connectionString =
                "Server=(localdb)\\mssqllocaldb;Database=ConferenceManager_Test;Trusted_Connection=True;MultipleActiveResultSets=true";
            var optionsBuilder = new DbContextOptionsBuilder<ConferenceManagerContext>()
                .UseSqlServer(connectionString)
                .UseLazyLoadingProxies();
            context = new ConferenceManagerContext(optionsBuilder.Options);
            unit = new ConferenceManagerUnit(context);

            attendees = new Mock<IConferenceManagerRepository<Attendee>>();
            attendees.Setup(m => m.Get(It.IsAny<QueryOptions<Attendee>>())).Returns(new Attendee());
            attendees.Setup(m => m.List(It.IsAny<QueryOptions<Attendee>>())).Returns(new List<Attendee>());

            conferences = new Mock<IConferenceManagerRepository<Conference>>();
            conferences.Setup(m => m.Get(It.IsAny<QueryOptions<Conference>>())).Returns(new Conference());
            conferences.Setup(m => m.List(It.IsAny<QueryOptions<Conference>>())).Returns(new List<Conference>());

            presentations = new Mock<IConferenceManagerRepository<Presentation>>();
            presentations.Setup(m => m.Get(It.IsAny<QueryOptions<Presentation>>())).Returns(new Presentation());
            presentations.Setup(m => m.List(It.IsAny<QueryOptions<Presentation>>())).Returns(new List<Presentation>());

            rooms = new Mock<IConferenceManagerRepository<Room>>();
            rooms.Setup(m => m.Get(It.IsAny<QueryOptions<Room>>())).Returns(new Room());
            rooms.Setup(m => m.List(It.IsAny<QueryOptions<Room>>())).Returns(new List<Room>());

            venues = new Mock<IConferenceManagerRepository<Venue>>();
            venues.Setup(m => m.Get(It.IsAny<QueryOptions<Venue>>())).Returns(new Venue());
            venues.Setup(m => m.List(It.IsAny<QueryOptions<Venue>>())).Returns(new List<Venue>());

            mockUnit = new Mock<IConferenceManagerUnit>();
            mockUnit.Setup(m => m.Attendees).Returns(attendees.Object);
            mockUnit.Setup(m => m.Conferences).Returns(conferences.Object);
            mockUnit.Setup(m => m.Presentations).Returns(presentations.Object);
            mockUnit.Setup(m => m.Rooms).Returns(rooms.Object);
            mockUnit.Setup(m => m.Venues).Returns(venues.Object);
        }
    }
}
