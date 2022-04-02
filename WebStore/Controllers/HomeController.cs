using Microsoft.AspNetCore.Mvc;
using WebStore.Models;

namespace WebStore.Controllers
{
    public class HomeController : Controller
    {
        private static readonly List<Employee> _employees = new()
        {
            new Employee()
            {
                Age = 23, Birthday = new DateTime(1991, 05, 20), DepartamentName = "Vanzari", FirstName = "Aurel",
                LastName = "Cavaz", Id = 1, PatronimicName = "Joricovici"
            },
            new Employee()
            {
                Age = 23, Birthday = new DateTime(1991, 05, 20), DepartamentName = "Administrare", FirstName = "Ion",
                LastName = "Frunze", Id = 2, PatronimicName = "Ionovici"
            },
            new Employee()
            {
                Age = 23, Birthday = new DateTime(1991, 05, 20), DepartamentName = "Auxiliar", FirstName = "Iura",
                LastName = "Streltov", Id = 3, PatronimicName = "Hersono"
            },
        };

        private readonly IConfiguration _configuration;

        public HomeController(IConfiguration Configuration)
        {
            _configuration = Configuration;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ContentString(string id = "-id-")
        {
            return Content($"content: {id}");
        }  

        public IActionResult ConfigString()
        {
            return Content($"content: {_configuration["ServerGreetings"]}");
        }

        public IActionResult ShowEmployees()
        {
            return View(_employees);
        }
        public IActionResult ShowEmployeeDescription(int id = 1)
        {
            return View(_employees[id-1]);
        }
    }
}
