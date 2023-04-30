using HW_4.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace HW_4.Controllers
{
    public class RegistrationController : Controller
    {
        [Route("/Registration/")]
        public IActionResult Register()
        {
            ViewBag.Title = "Registration";
            return View();
        }

        [Route("/Registration/")]
        [HttpPost]
        public IActionResult Register(ASPDeveloper developer)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Complete", developer);
            }
            ViewBag.Title = "Registration";
            return View(developer);
        }

        public IActionResult Complete(ASPDeveloper developer)
        {
            ViewBag.Title = "Successful registration!";
            return View(developer);
        }
    }
}
