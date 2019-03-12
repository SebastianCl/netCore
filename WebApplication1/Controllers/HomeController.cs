namespace WebApplication1.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Models;

    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return Content("Hola parcer@s! I am learning MVC!");
        }        public IActionResult Index2()
        {
            return View(); // View for this 'Index2' action method
        }        [SundayFilter]        public IActionResult Employee()
        {
            //Sample Model - Usually this comes from database
            Employee emp1 = new Employee
            {
                EmployeeId = 1,
                Name = "Jon Skeet",
                Designation = " Software Architect"
            };
            ViewBag.Company = "Google Inc";
            ViewData["CompanyLocation"] = "United States";
            
            return View(emp1);
        }        public IActionResult IndexUpper()
        {
            return new UpperStringActionResult("Hey parcer@! I am learning MVC!");

        }
    }
}
