using Microsoft.AspNetCore.Mvc;

namespace WebStore.Controllers
{
    public class _404 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
