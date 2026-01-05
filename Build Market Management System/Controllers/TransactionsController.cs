using Build_Market_Management_System.Models;
using Build_Market_Management_System.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Build_Market_Management_System.Controllers
{
    public class TransactionsController : Controller
    {
        public IActionResult Index()
        {
            var model = new TransactionsViewModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult Search(TransactionsViewModel transactionViewModel)
        {
            var transactions = TransactionsRepository.Search(
                transactionViewModel.CashierName,
                transactionViewModel.StartDate,
                transactionViewModel.EndDate);

            transactionViewModel.Transactions = transactions;
            return View("Index", transactionViewModel);
        }
    }
}
