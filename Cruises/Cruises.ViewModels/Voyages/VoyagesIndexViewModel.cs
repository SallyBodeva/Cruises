namespace Cruises.ViewModels.Voyages
{
    using Cruises.ViewModels.Shared;
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class VoyagesIndexViewModel :PagingViewModel
    {
        public List<VoyageIndexViewModel> Voyages { get; set; } = new List<VoyageIndexViewModel>();
    }
}
