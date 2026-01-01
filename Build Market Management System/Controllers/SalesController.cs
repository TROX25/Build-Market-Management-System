using Build_Market_Management_System.Models;
using Build_Market_Management_System.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Build_Market_Management_System.Controllers
{
    public class SalesController : Controller
    {
        public IActionResult Index()
        {
            var salesViewModel = new SalesViewModel
            {
                Categories = CategoriesRepository.GetCategories()
            };
            return View(salesViewModel);
        }

        public IActionResult ProductDetailsPartial(int productId)
        {
            var product = ProductsRepository.GetProductById(productId);
            return PartialView("_SellProduct", product);
        }

        [HttpPost]
        public IActionResult Sell(SalesViewModel salesViewModel)
        {
            if (ModelState.IsValid)
            {
                // sell product
            }

            var product = ProductsRepository.GetProductById(salesViewModel.SelectedProductId);
            salesViewModel.SelectedCategoryId = (product?.CategoryId == null) ? 0 : product.CategoryId.Value;
            // Potrzebuje jeszcze raz pobrac kategorie, zeby wypelnic dropdown w widoku
            // poniewaz przy postowaniu modelu nie sa one przesylane
            salesViewModel.Categories = CategoriesRepository.GetCategories();
            return View("Index", salesViewModel);
        }
    }
}
