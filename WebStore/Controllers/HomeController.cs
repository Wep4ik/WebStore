using Microsoft.AspNetCore.Mvc;

namespace WebStore.Controllers
{
    public class HomeController : Controller
    {
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
    }
}
