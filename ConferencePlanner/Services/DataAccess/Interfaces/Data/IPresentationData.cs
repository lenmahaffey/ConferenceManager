using ConferenceManager.Models.Entities;
using System.Collections.Generic;

namespace ConferenceManager.Services.Interfaces
{
    interface IPresentationData
    {
        Presentation GetPresentation(int id);
        IEnumerable<Presentation> GetPresentations();
        void DeletePresentation(Presentation Presentation);
        public void AddPresentation(Presentation presentation);
        public void EditPresentation(Presentation presentation);
    }
}
