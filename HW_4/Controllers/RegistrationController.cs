using HW_4.Data.Models;
using HW_4.Data.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace HW_4.Controllers
{
    public class RegistrationController : Controller
    {
        private readonly DeveloperRepository _devRep;

        public RegistrationController(DeveloperRepository devRep)
        {
            _devRep = devRep;
        }

        [Route("/registration")]
        public IActionResult Register()
        {
            ViewBag.Title = "Registration";
            return View();
        }

        [Route("/registration")]
        [HttpPost]
        public IActionResult Register(ASPDeveloper developer)
        {
            if (_devRep.DeveloperExists(developer.email))
            {
                ModelState.AddModelError(string.Empty, "You are already registered!");
            }

            if (ModelState.IsValid)
            {
                _devRep.AddDeveloper(developer);
                return RedirectToAction("Complete", developer);
            }

            ViewBag.Title = "Registration";
            ViewBag.Message = "Registration";
            return View(developer);
        }

        public IActionResult Complete(ASPDeveloper developer)
        {
            ViewBag.Title = "Successful registration!";
            return View(developer);
        }
    }
}