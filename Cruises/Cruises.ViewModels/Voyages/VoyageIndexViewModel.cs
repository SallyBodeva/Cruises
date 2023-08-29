namespace Cruises.ViewModels.Voyages
{
    public class VoyageIndexViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string StartHarbour { get; set; }
        public string DestinationHarbour { get; set; }
        public string Duration { get; set; }
        public string Ship { get; set; }
        public string TicketPrice { get; set; }

        public string ImageUrl { get; set; } = "https://www.msccruisesusa.com/-/media/US/2022/Ships/MSC%20Seascape/New%20Ship%20page%20Images/seascape-landing-page-hero-desktop.jpg";
    }
}
