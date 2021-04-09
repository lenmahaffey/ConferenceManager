using ConferenceManager.Models.Entities;
using ConferenceManager.Services.DataAccess;
using ConferenceManager.Services.DataAccess.Interfaces;
using Microsoft.EntityFrameworkCore;
using Moq;

namespace ConferenceManager_Test
{
    public class ConferenceManagerBase_Test
    {
        protected ConferenceManagerContext context { get; }
        protected Mock<IConferenceManagerUnit> unit {get; set;}
        protected Mock<IConferenceManagerRepository<Attendee>> attendees { get; set; }
        protected Mock<IConferenceManagerRepository<Conference>> conferences { get; set; }
        protected Mock<IConferenceManagerRepository<Presentation>> presentations { get; set; }
        protected Mock<IConferenceManagerRepository<Venue>> venues { get; set; }
        protected Mock<IConferenceManagerRepository<Room>> rooms { get; set; }

        public ConferenceManagerBase_Test()
        {
            string connectionString =
                "Server=(localdb)\\mssqllocaldb;Database=ConferenceManager_Test;Trusted_Connection=True;MultipleActiveResultSets=true";
            var options = new DbContextOptionsBuilder<ConferenceManagerContext>()
                .UseSqlServer(connectionString);
            context = new ConferenceManagerContext(options.Options);
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

            unit = new Mock<IConferenceManagerUnit>();
            unit.Setup(m => m.Attendees).Returns((ConferenceManagerRepository<Attendee>)attendees.Object);
            unit.Setup(m => m.Conferences).Returns((ConferenceManagerRepository<Conference>)conferences.Object);
            unit.Setup(m => m.Presentations).Returns((ConferenceManagerRepository<Presentation>)presentations.Object);
            unit.Setup(m => m.Rooms).Returns((ConferenceManagerRepository<Room>)conferences.Object);
            unit.Setup(m => m.Venues).Returns((ConferenceManagerRepository<Venue>)conferences.Object);
        }
    }
}
