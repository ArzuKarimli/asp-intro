using asp.Models;
using asp.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace asp.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            var datas = GetAll();
            List<BookVM> books= new List<BookVM>();
            foreach (var data in datas)
            {
                books.Add(new BookVM
                {
                    Name = data.Name,
                });
            }

            return View(books);
        }
        private List<Book> GetAll()
        {
            return new List<Book>
            {
                new()
                {
                    Id = 1,
                    Name="Ek Samandar, Mere Anda"
                },
                new()
                {
                    Id = 2,
                    Name="Four Stars of Destiny"
                },
                new()
                {
                    Id = 3,
                    Name="Victory City"
                },
                new()
                {
                    Id = 4,
                    Name="Queen of Fire"
                },
                new()
                {
                    Id = 5,
                    Name="By God’s Decree"
                }
            };
        }
    }
}
