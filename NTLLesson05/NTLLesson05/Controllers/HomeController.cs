using Microsoft.AspNetCore.Mvc;
using NTLLesson05.Models;
using System.Diagnostics;

namespace NTLLesson05.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        //lập trình viên trên view với 
        public IActionResult RazorCode()
        {
            return View();
        }
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
