using Microsoft.AspNetCore.Mvc;
using System.Net.Cache;
using System.Security.AccessControl;
using WebApplication1.Models;
using WebApplication1.ViewModels;
using WebApplication1.ViewModels.Student;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        //public int GetNum(int id)
        //{
        //    //return 100;
        //    return id;
        //}

        //public string Search(string searchText)
        //{
        //    return searchText;
        //}
        //public string Search(string searchText,string name)
        //{
        //    if (name.Contains(searchText))
        //    {
        //        return "Yes";
        //    }
        //    return "No";
        //}
        public IActionResult Index()
        {
            var datas = GetAllStudents();
            List<StudentVM> students = new List<StudentVM>();

            foreach (var item in datas)
            {
                students.Add
                     (new StudentVM
                     {
                            FullName=item.FullName
                     });
            }

            Book book = new()
            {
                Id = 1,
                Name = "Nisenin kitabi"
            };

            HomeVM model = new()
            {
                students= students,
                book= book

            };

            return View(model);
            //return Content("salamlar");
            //return Json("salam");
        }

        private List<Student> GetAllStudents()
        {
            return new List<Student>
            {
                new (){
                     Id=1,
                     FullName="Tunzale Memmedova",
                     Age=25
                },
                new(){
                     Id=2,
                     FullName=" Nurlan Musayev",
                     Age=22
                },
                new (){
                     Id=3,
                     FullName="Haci Ehmedov",
                     Age=29
                }
            };
        }
    }
}
