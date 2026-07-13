using Microsoft.AspNetCore.Mvc;

namespace PraticeWebApplication.Controllers
{
    public class OperationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string num1,string num2,string btnadd)
        {
            if (btnadd.Equals("+"))
            {
                ViewBag.Result = Convert.ToInt32(num1) + Convert.ToInt32(num2);
            }
            else if (btnadd.Equals("-"))
            {
                ViewBag.Result = Convert.ToInt32(num1) - Convert.ToInt32(num2);
            }
            else if (btnadd.Equals("*"))
            {
                ViewBag.Result = Convert.ToInt32(num1) * Convert.ToInt32(num2);
            }
            else
            {
                ViewBag.Result = Convert.ToInt32(num1) / Convert.ToInt32(num2);
            }
            return View();
        }
    }
}
