using Microsoft.AspNetCore.Mvc;
using NTLLesson06.Models;
using System.Reflection.Metadata.Ecma335;

namespace NTLLesson06.ViewComponents
{
    public class CategoryViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(int? n)
        {
            List<Category> categories = new List<Category>
            {
                new Category { CategoryId = 1, CategoryName="Electronls",IsActive=true},
                new Category { CategoryId = 2, CategoryName = "Books", IsActive = true },
                new Category { CategoryId = 3, CategoryName = "Clothing", IsActive = false },
                new Category { CategoryId = 4, CategoryName = "Home & Kitchen", IsActive = true }
            };
            n = n ?? 0;
            var search = categories.Where(c =>c.CategoryId > n).ToList();
            return View(categories);
        }
    }
}
