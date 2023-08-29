using Cruises.Service;
using Cruises.ViewModels.Voyages;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Cruises.WebApp.Controllers
{
    public class VoyagesController : Controller
    {
        private readonly VoyageService voyagesService;
        public VoyagesController()
        {
            voyagesService = new VoyageService();
        }
        public IActionResult Index(int page = 1)
        {
            VoyagesIndexViewModel models = new VoyagesIndexViewModel();
            models.PageNumber = page;
            models= voyagesService.GetVoyages(models);
            return View(models);
        }
        public IActionResult Cheapest()
        {
            List<VoyageIndexViewModel> model = voyagesService.GetCheapestVoyages();
            return View(model);
        }

        public IActionResult Expensive()
        {
            List<VoyageIndexViewModel> model = voyagesService.GetMostExpensiveVoyages();
            return View(model);
        }
    }
}
