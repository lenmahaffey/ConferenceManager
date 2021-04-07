using ConferenceManager.Models.Entities;
using System.Collections.Generic;

namespace ConferenceManager.Services.Interfaces
{
    interface IVenuesData
    {
        Venue GetVenue(int id);
        IEnumerable<Venue> GetVenues();
        void DeleteVenue(Venue venue);
        public void AddVenue(Venue venue);
        public void EditVenue(Venue venue);
    }
}
