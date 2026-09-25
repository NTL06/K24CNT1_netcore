using Lesson08Models.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Lesson08Models.Controllers
{
    public class NTLHomeController : Controller
    {
        private readonly ILogger<NTLHomeController> _logger;
        public NTLHomeController(ILogger<NTLHomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult NTLIndex()
        {
            return View();
        }

        public IActionResult NTLPrivacy()
        {
            return View();
        }
        public IActionResult NTLAbout()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
