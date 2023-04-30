using Microsoft.AspNetCore.Mvc;

namespace HW_4.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        public IActionResult Index()
        {
            ViewBag.Title = "I am an ASP.NET developer";
            return View();
        }
    }
}
