using asp.Models;
using asp.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace asp.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            var datas = GetAll();
            List<EmployeeVM> employees = new List<EmployeeVM>();
            foreach (var data in datas)
            {
                employees.Add(new EmployeeVM
                {
                    Name = data.Name,
                    Surname = data.Surname,
                    Salary  = data.Salary,
                    Age = data.Age,
                });
            }


            return View(employees);
        }

        private List<Employee> GetAll()
        {
            return new List<Employee>
            {
                new()
                {
                    Id = 1,
                    Age = 29,
                    Name="Nesir",
                    Surname="Kerimov",
                    Salary=1500
                },
                  new()
                {
                    Id = 2,
                    Age = 26,
                    Name="Arzu",
                    Surname="Kerimov",
                    Salary=500
                },
                    new()
                {
                    Id = 3,
                    Age = 25,
                    Name="Nezrin",
                    Surname="Eliyeva",
                    Salary=1000
                },
                      new()
                {
                    Id = 2,
                    Age = 32,
                    Name="Sehla",
                    Surname="Abbasova",
                    Salary=1700
                }
            };
        }
    }
}
