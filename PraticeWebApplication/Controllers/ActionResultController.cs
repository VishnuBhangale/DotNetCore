using Microsoft.AspNetCore.Mvc;

namespace PraticeWebApplication.Controllers
{
    public class ActionResultController : Controller
    {
        public IActionResult Index()
        {
            // return the view by its logical name (no file extension)
            return View("hello");
        }
        public IActionResult MyAds()
        {
            return PartialView(); ;
        }
    }
}
