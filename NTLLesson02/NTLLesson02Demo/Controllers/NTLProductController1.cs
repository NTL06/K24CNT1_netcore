using Microsoft.AspNetCore.Mvc;

namespace NTLLesson02Demo.Controllers
{
    public class NTLProductController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
