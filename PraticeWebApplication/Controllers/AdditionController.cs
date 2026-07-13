using Microsoft.AspNetCore.Mvc;
using PraticeWebApplication.Models;
using PraticeWebApplication.Services;

namespace PraticeWebApplication.Controllers
{
    public class AdditionController : Controller
    {
        private readonly AdditionService _additionService;

        public AdditionController(AdditionService addservice)
        {
            _additionService = addservice ?? throw new ArgumentNullException(nameof(addservice));
        }
        public IActionResult Index() //Http Get to load the view
        {
            AdditionModel additionModel= new AdditionModel();
            return View(additionModel);
        }
        [HttpPost]
        public IActionResult Index(AdditionModel additionModel) //Http Post to handle form submission
        {
            if (ModelState.IsValid)
            {
                int result = _additionService.AddTwoNumbers(additionModel.Num1, additionModel.Num2);
                ViewBag.Result = result;
            }
            return View(additionModel);
        }
    }
}
