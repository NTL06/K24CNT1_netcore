using Microsoft.AspNetCore.Mvc;
using NTLLesson002Demo.Models;

namespace NTLLesson002Demo.Controllers
{
    public class NTLProductController : Controller
    {
        public IActionResult Index()
        {
            //đưa dữ liệu ra view
            ViewBag.name = "Lệ";
            ViewData["address"] = "Fit NTU";
            TempData["UNI"] = "Trường Đại Học Nguyễn Trãi";

            return View();
        }

        //Chi tiết sản phẩm
        public IActionResult GetProduct()
        { 
        //Mock data
        NTLProduct NTLProduct = new NTLProduct()
            {
                ProductId="P001",
                ProductName="Laptop Dell Vostro",
                YearRelease=2024,
                Price=12000000,

            };
            ViewData["productVD"] = NTLProduct;
            ViewBag.productVB = NTLProduct;

            return View();
        }
    }
}
