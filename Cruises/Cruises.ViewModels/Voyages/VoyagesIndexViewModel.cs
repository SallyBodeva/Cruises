namespace Cruises.ViewModels.Voyages
{
    using Cruises.ViewModels.Shared;
    using System.Collections.Generic;
    public class VoyagesIndexViewModel:PagingViewModel
    {
        public List<VoyageIndexViewModel> Voyages { get; set; } = new List<VoyageIndexViewModel>();
    }
}

