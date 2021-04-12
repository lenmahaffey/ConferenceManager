using ConferenceManager.Models.Entities;
using System.Collections.Generic;

namespace ConferenceManager.Services.Interfaces
{
    interface IConferencesData
    {
        Conference GetConference(int id);
        IEnumerable<Conference> GetConferences();
        void DeleteConference(Conference Conference);
        public void AddConference(Conference conference);
        public void EditConference(Conference conference);
    }
}
