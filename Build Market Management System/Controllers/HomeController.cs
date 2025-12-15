using Microsoft.AspNetCore.Mvc;

namespace Build_Market_Management_System.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
