using ConferenceManager.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace ConferenceManager_Test
{
    public class ConferenceManagerContext_Test : ConferenceManagerTestBase
    {
        [Fact]
        public void TestAttendees()
        {
            //Verify attendee from seed data present in db
            //Arrange
            int expectedID = 101;
            string expectedFirstName = "Steve";
            string expectedLastName = "Johnson";
            string expectedEmail = "steve@juno.com";

            //Act
            Attendee queryResult = context.Attendees.Find(101);

            //Assert
            Assert.Equal(expectedID, queryResult.ID);
            Assert.Equal(expectedFirstName, queryResult.FirstName);
            Assert.Equal(expectedLastName, queryResult.LastName);
            Assert.Equal(expectedEmail, queryResult.Email);

            Assert.True(queryResult.ConferenceAttendees == null);
        }
    }
}
