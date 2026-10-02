using Microsoft.AspNetCore.Mvc;

namespace NTLLesson13Layout.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Search(String keyword)
        {
            ViewData["Keyword"] = keyword;
            return View();
        }
        public IActionResult Host()
        {
            return View();
        }
    }
}
