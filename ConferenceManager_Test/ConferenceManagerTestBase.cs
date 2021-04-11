using ConferenceManager.Models.Entities;
using ConferenceManager.Services.DataAccess;
using ConferenceManager.Services.DataAccess.Interfaces;
using Microsoft.EntityFrameworkCore;
using Moq;

namespace ConferenceManager_Test
{
    public class ConferenceManagerTestBase
    {
        protected ConferenceManagerContext context { get; }
        protected ConferenceManagerUnit  unit { get; }
        protected Mock<IConferenceManagerUnit> mockUnit {get; set;}
        private Mock<IConferenceManagerRepository<Attendee>> attendees { get; set; }
        private Mock<IConferenceManagerRepository<Conference>> conferences { get; set; }
        private Mock<IConferenceManagerRepository<Presentation>> presentations { get; set; }
        private Mock<IConferenceManagerRepository<Venue>> venues { get; set; }
        private Mock<IConferenceManagerRepository<Room>> rooms { get; set; }

        public ConferenceManagerTestBase()
        {
            string connectionString =
                "Server=(localdb)\\mssqllocaldb;Database=ConferenceManager_Test;Trusted_Connection=True;MultipleActiveResultSets=true";
            var options = new DbContextOptionsBuilder<ConferenceManagerContext>()
                .UseSqlServer(connectionString);
            context = new ConferenceManagerContext(options.Options);
            unit = new ConferenceManagerUnit(context);
            //GetUnitOfWork();
        }

        private void GetUnitOfWork()
        {
            //Not Working
            attendees = new Mock<IConferenceManagerRepository<Attendee>>();
            attendees.Setup(m => m.Get(It.IsAny<QueryOptions<Attendee>>())).Returns(new Attendee());

            conferences = new Mock<IConferenceManagerRepository<Conference>>();
            conferences.Setup(m => m.Get(It.IsAny<QueryOptions<Conference>>())).Returns(new Conference());

            presentations = new Mock<IConferenceManagerRepository<Presentation>>();
            presentations.Setup(m => m.Get(It.IsAny<QueryOptions<Presentation>>())).Returns(new Presentation());

            rooms = new Mock<IConferenceManagerRepository<Room>>();
            rooms.Setup(m => m.Get(It.IsAny<QueryOptions<Room>>())).Returns(new Room());

            venues = new Mock<IConferenceManagerRepository<Venue>>();
            venues.Setup(m => m.Get(It.IsAny<QueryOptions<Venue>>())).Returns(new Venue());

            mockUnit = new Mock<IConferenceManagerUnit>();
            mockUnit.Setup(m => m.Attendees).Returns((ConferenceManagerRepository<Attendee>)attendees.Object);
            mockUnit.Setup(m => m.Conferences).Returns((ConferenceManagerRepository<Conference>)conferences.Object);
            mockUnit.Setup(m => m.Presentations).Returns((ConferenceManagerRepository<Presentation>)presentations.Object);
            mockUnit.Setup(m => m.Rooms).Returns((ConferenceManagerRepository<Room>)conferences.Object);
            mockUnit.Setup(m => m.Venues).Returns((ConferenceManagerRepository<Venue>)conferences.Object);
        }
    }
}
