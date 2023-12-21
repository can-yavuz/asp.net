using Basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace Basics.Controllers
{
   public class EmployeeController : Controller
   {
        public IActionResult Index1()
        {
            String message = $"Hello World. {DateTime.Now.ToString()}";
            return View("Index1", message);
        }

        public IActionResult Index2()
        {

            Double date = DateTime.Now.Day;

            return View("index2", date);
        }

        public IActionResult Index3(){
            String[] names = new String[]{
                "Ahmet",
                "Mehmet",
                "Mustafa"
            };
            return View("index3", names);
        }

        public IActionResult Index4(){

            var list = new List<Employee>(){

                new Employee(){firstName = "Can", lastName = "Yavuz", id = 1, yas = 22},
                new Employee(){firstName = "Tuğçe", lastName = "Köse", id = 2, yas = 34},
                new Employee(){firstName = "Tuğba", lastName = "Kalem", id = 3, yas = 36},
                new Employee(){firstName = "Hilal", lastName = "Harmancı", id = 4, yas = 33}


            };


            return View("index4", list);
        }
    
   }
}