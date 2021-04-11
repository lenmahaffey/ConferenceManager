using ConferenceManager.Models.Entities;
using ConferenceManager.Services.DataAccess;
using ConferenceManager.Testing;
using ConferenceManager.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ConferenceManager_Testing
{
    public class ConferenceViewModel_Test : ConferenceManagerTestBase
    {
        int conferenceID = 1001;

        [Fact]
        public void ConferenceProperty_Test()
        {
            ConferenceViewModel model = new ConferenceViewModel
            {
                Conference = unit.Conferences.Get(conferenceID),
                Attendees = unit.ConferenceAttendees.List(new QueryOptions<ConferenceAttendee>
                {
                    Where = c => c.ConferenceID == conferenceID
                })
            };

            Assert.True(conferenceID == model.Conference.ID);
            Assert.True(model.Attendees != null);
        }
    }
}
