using asp.Models;
using asp.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace asp.Controllers
{
    public class ProductController : Controller
    {
       public IActionResult Index()
        {
            var datas = GetAll();
            List<ProductVM> products = new List<ProductVM>();
            foreach (var item in datas)
            {
                products.Add(new ProductVM
                {
                    
                    Name = item.Name,
                    Price = item.Price,
                   Count = item.Count,
                   Description = item.Description

                });
              
            }
            return View(products); 
        }

        private List<Product> GetAll()
        {
            return new List<Product>
            {
                new()
                {
                    Id = 1,
                    Name = "Xiaomi MI 12",
                    Price=1000,
                    Description=" Xiaomi's phone known for its powerful performance and affordable price. It features advanced camera systems and a high battery capacity.",
                    Count=15,
                },
                new()
                {
                    Id=2,
                    Name="Samsung Galaxy S22 Ultra",
                    Price=1200,
                    Description=" Samsung's flagship phone. It features a high-performance processor, a massive display, a multi-camera system, and advanced S Pen support.",
                    Count=18,
                } ,
                new()
                {
                    Id = 3,
                    Name = "Google Pixel 6 Pro",
                    Price=1100,
                    Description=" Google's latest Pixel phone. It catches attention with its advanced camera features, smart software features, and sleek design.",
                    Count=10,
                },

            };
        }
    }
}
