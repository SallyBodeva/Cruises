using Cruises.Service;
using Cruises.ViewModels.Voyages;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Cruises.WebApp.Controllers
{
    public class VoyageController : Controller
    {
        private readonly VoyageService voyageService;
        public VoyageController()
        {
            this.voyageService = new VoyageService();
        }
        public IActionResult Index(int page =1)
        {
            VoyagesIndexViewModel models = new VoyagesIndexViewModel();
            models.PageNumber = page;
            models= voyageService.GetVoyages(models);
            return View(models);
        }
        public IActionResult Cheapest()
        {
            List<VoyageIndexViewModel> model = voyageService.GetCheapestVoyages();
            return View(model);
        }
        public IActionResult MostExpensive()
        {
            List<VoyageIndexViewModel> model = voyageService.GetMostExpensiveVoyages();
            return View(model);
        }
    }
}
