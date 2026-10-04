using Microsoft.AspNetCore.Mvc;

namespace NTLLab7.Areas.Admins.Controllers
{
    [Area("Admins")]
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
