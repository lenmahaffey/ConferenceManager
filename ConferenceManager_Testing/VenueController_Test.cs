using ConferenceManager.Models.Entities;
using ConferenceManager.Services.DataAccess;
using ConferenceManager.Services.DataAccess.Interfaces;
using ConferenceManager.Testing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Moq;
using System.Collections.Generic;

namespace ConferenceManager_Testing
{
    class VenueController_Test : ConferenceManagerTestBase
    {
        private Mock<IConferenceManagerRepository<Venue>> venues { get; }
        private Mock<ITempDataDictionary> mockHttpContext { get; }
        public VenueController_Test()
        {
            mockHttpContext = new Mock<ITempDataDictionary>();
            venues = new Mock<IConferenceManagerRepository<Venue>>();
            venues.Setup(m => m.Get(It.IsAny<QueryOptions<Venue>>())).Returns(new Venue());
            venues.Setup(m => m.Get(It.IsAny<int>())).Returns(new Venue());
            venues.Setup(m => m.List(It.IsAny<QueryOptions<Venue>>())).Returns(new List<Venue>());
        }
    }
}
