namespace Cruises.ViewModels.Voyages
{
    public class VoyageIndexViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Harbour { get; set; }
        public string DestinationHarbour { get; set; }
        public string Duration { get; set; }
        public string Ship { get; set; }
        public string TicketPrice { get; set; }
        public string ImageURL { get; set; } = "https://i.pinimg.com/originals/69/a5/78/69a578808ffbf5d351b79cc83a0025c7.jpg";
    }
}
