using Microsoft.AspNetCore.Mvc;

namespace PraticeWebApplication.Controllers
{
    public class FirstController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
