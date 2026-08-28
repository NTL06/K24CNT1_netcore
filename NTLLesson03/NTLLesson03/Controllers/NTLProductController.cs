using Microsoft.AspNetCore.Mvc;
using NTLLesson03.Models;

namespace NTLLesson03.Controllers
{
    public class NTLProductController : Controller
    {
        private readonly List<NTLProduct> _products=new()
        {
            new NTLProduct { NTLProductId = "P001", NTLProductName = "Laptop Dell XPS 13", NTLYearRelease = "2022", NTLPrice = "32000" },
        new NTLProduct { NTLProductId = "P002", NTLProductName = "iPhone 14 Pro", NTLYearRelease = "2023", NTLPrice = "28000" },
        new NTLProduct { NTLProductId = "P003", NTLProductName = "Samsung Galaxy S23", NTLYearRelease = "2023", NTLPrice = "25000" },
        new NTLProduct { NTLProductId = "P004", NTLProductName = "Sony WH-1000XM5 Headphones", NTLYearRelease = "2022", NTLPrice = "8500" },
        new NTLProduct { NTLProductId = "P005", NTLProductName = "MacBook Air M2", NTLYearRelease = "2022", NTLPrice = "27000" },
        new NTLProduct { NTLProductId = "P006", NTLProductName = "iPad Pro 12.9", NTLYearRelease = "2021", NTLPrice = "22000" },
        new NTLProduct { NTLProductId = "P007", NTLProductName = "PlayStation 5", NTLYearRelease = "2020", NTLPrice = "15000" },
        new NTLProduct { NTLProductId = "P008", NTLProductName = "Xbox Series X", NTLYearRelease = "2020", NTLPrice = "14000" },
        new NTLProduct { NTLProductId = "P009", NTLProductName = "Canon EOS R6 Camera", NTLYearRelease = "2021", NTLPrice = "18000" },
        new NTLProduct { NTLProductId = "P010", NTLProductName = "Apple Watch Ultra", NTLYearRelease = "2023", NTLPrice = "12000" }

        };
        public IActionResult Index()
        {
            return Json(_products);
        }

        //Get: danh sách sản phẩm
        public IActionResult NTLGetAllProduct()
        {
            ViewData["product"] = _products;
            return View();
        }
        public IActionResult NTLGetListProduct()
        {
            ViewData["product"] = _products;
            return View(_products);
        }
    }
}
