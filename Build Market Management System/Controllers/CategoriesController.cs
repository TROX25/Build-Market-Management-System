using Microsoft.AspNetCore.Mvc;
using Build_Market_Management_System.Models;

namespace Build_Market_Management_System.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            var categories = CategoriesRepository.GetCategories();
            return View(categories);
        }

        public IActionResult Edit(int? id)
        {
            var category = CategoriesRepository.GetCategoryById(id ?? 0);

            return View(category);
        }
    }
}
