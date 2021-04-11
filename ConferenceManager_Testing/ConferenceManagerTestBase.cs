using ConferenceManager.Models.Entities;
using ConferenceManager.Services.DataAccess;
using ConferenceManager.Services.DataAccess.Interfaces;
using Microsoft.EntityFrameworkCore;
using Moq;

namespace ConferenceManager.Testing
{
    public class ConferenceManagerTestBase
    {
        protected ConferenceManagerContext context { get; }
        protected ConferenceManagerUnit  unit { get; }
        protected Mock<IConferenceManagerUnit> mockUnit {get; set;}
        private Mock<ConferenceManagerRepository<Attendee>> attendees { get; set; }
        private Mock<ConferenceManagerRepository<Conference>> conferences { get; set; }
        private Mock<ConferenceManagerRepository<Presentation>> presentations { get; set; }
        private Mock<ConferenceManagerRepository<Venue>> venues { get; set; }
        private Mock<ConferenceManagerRepository<Room>> rooms { get; set; }

        public ConferenceManagerTestBase()
        {
            string connectionString =
                "Server=(localdb)\\mssqllocaldb;Database=ConferenceManager_Test;Trusted_Connection=True;MultipleActiveResultSets=true";
            var optionsBuilder = new DbContextOptionsBuilder<ConferenceManagerContext>()
                .UseSqlServer(connectionString)
                .UseLazyLoadingProxies();
            context = new ConferenceManagerContext(optionsBuilder.Options);
            unit = new ConferenceManagerUnit(context);
            GetUnitOfWork();
        }

        private void GetUnitOfWork()
        {
            //Not Working
            attendees = new Mock<ConferenceManagerRepository<Attendee>>();
            attendees.Setup(m => m.Get(It.IsAny<QueryOptions<Attendee>>())).Returns(new Attendee());

            conferences = new Mock<ConferenceManagerRepository<Conference>>();
            conferences.Setup(m => m.Get(It.IsAny<QueryOptions<Conference>>())).Returns(new Conference());

            presentations = new Mock<ConferenceManagerRepository<Presentation>>();
            presentations.Setup(m => m.Get(It.IsAny<QueryOptions<Presentation>>())).Returns(new Presentation());

            rooms = new Mock<ConferenceManagerRepository<Room>>();
            rooms.Setup(m => m.Get(It.IsAny<QueryOptions<Room>>())).Returns(new Room());

            venues = new Mock<ConferenceManagerRepository<Venue>>();
            venues.Setup(m => m.Get(It.IsAny<QueryOptions<Venue>>())).Returns(new Venue());

            mockUnit = new Mock<IConferenceManagerUnit>();
            mockUnit.Setup(m => m.Attendees).Returns(attendees.Object);
            mockUnit.Setup(m => m.Conferences).Returns(conferences.Object);
            mockUnit.Setup(m => m.Presentations).Returns(presentations.Object);
            mockUnit.Setup(m => m.Rooms).Returns(rooms.Object);
            mockUnit.Setup(m => m.Venues).Returns(venues.Object);
        }
    }
}
