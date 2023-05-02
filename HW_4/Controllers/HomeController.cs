using HW_4.Data.Repositories;
using HW_4.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace HW_4.Controllers
{
    public class HomeController : Controller
    {
        private readonly DeveloperRepository _devRep;

        public HomeController(DeveloperRepository devRep)
        {
            _devRep = devRep;
        }

        [Route("")]
        public IActionResult Index()
        {
            ViewBag.Title = "I am ASP.NET developer";
            var developers = _devRep.Developers;
            var developersModel = new HomeViewModel
            {
                developers = developers,
                amount = developers.Count()
            };
            return View(developersModel);
        }

        [Route("/community")]
        public IActionResult Community()
        {
            ViewBag.Title = "ASP.NET Community";
            var developers = _devRep.Developers;
            var developersModel = new HomeViewModel
            {
                developers = developers,
                amount = developers.Count()
            };
            return View(developersModel);
        }
    }
}