using Microsoft.AspNetCore.Mvc;
using System.Net.Cache;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using asp.Models;
using asp.ViewModels;

namespace asp.Controllers
{
    public class AccountController : Controller
    {
       
        public IActionResult Index()
        {
            var users = GetAll();
            List<UserVM> datas= new List<UserVM>();

            foreach (var user in users)
            {
                datas.Add(
                    new UserVM
                    {
                        FullName=user.FullName,
                         Email = user.Email,
                         Address = user.Address,
                         Age = user.Age,

                    });
            }

            return View(datas);

        }

        private List<User> GetAll()
        {
            return new List<User>
            {
      new (){
                     Id=1,
                     FullName="Tunzale Memmedova",
                     Email="tunzale@gmail.com",
                     Address="Nesimi",
                     Age=25
                },
                new(){
                     Id=2,
                     FullName=" Nurlan Musayev",
                     Email="nurlan@gmail.com",
                     Address="Nizami",
                     Age=22
                },
                new (){
                     Id=3,
                     FullName="Haci Ehmedov",
                     Email="haci@gmail.com",
                     Address="Dernegul",
                     Age=29
                },
                  new (){
                     Id=4,
                     FullName="Arzu Kerimova",
                     Email="arzu@gmail.com",
                     Address="Yasamal",
                     Age=26
                },
                    new (){
                     Id=5,
                     FullName="ilham Abasli",
                     Email="Ilham@gmail.com",
                     Address="Dernegul",
                     Age=22
                },
                new (){
                     Id=6,
                     FullName="Meryem Ehmedova",
                     Email="meryem@gmail.com",
                     Address="Dernegul",
                     Age=23
                }
            };
        }
    }
}
