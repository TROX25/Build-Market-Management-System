using Microsoft.AspNetCore.Mvc;

namespace Build_Market_Management_System.Controllers
{
    public class Categories : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Edit(int id)
        {
            return View();
        }
    }
}
