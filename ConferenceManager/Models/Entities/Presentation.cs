namespace ConferenceManager.Models.Entities
{
    public class Presentation : Event
    {
        public int PresenterID { get; set; }
        public virtual Presenter Presenter { get; set; }

    }
}
