using WebApplication1.Models;
using WebApplication1.ViewModels.Student;

namespace WebApplication1.ViewModels
{
    public class HomeVM
    {
       public List<StudentVM> students { get; set; }
        public Book book { get; set; }
    }
}
