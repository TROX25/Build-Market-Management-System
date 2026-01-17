using Build_Market_Management_System.ViewModels;
using Microsoft.AspNetCore.Mvc;
using UseCases.DataStorePluginInterfaces;
using UseCases.Interfaces;


namespace Build_Market_Management_System.Controllers
{
    public class TransactionsController : Controller
    {
        private readonly IGetTodayTransactionUseCase getTodayTransactionUseCase;
        private readonly IRecordTransactionUseCase recordTransactionUseCase;
        private readonly ISearchTransactionsUseCase searchTransactionsUseCase;

        public TransactionsController(IGetTodayTransactionUseCase getTodayTransactionUseCase, 
            IRecordTransactionUseCase recordTransactionUseCase, 
            ISearchTransactionsUseCase searchTransactionsUseCase)
        {
            this.getTodayTransactionUseCase = getTodayTransactionUseCase;
            this.recordTransactionUseCase = recordTransactionUseCase;
            this.searchTransactionsUseCase = searchTransactionsUseCase;
        }
        public IActionResult Index()
        {
            var model = new TransactionsViewModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult Search(TransactionsViewModel transactionViewModel)
        {
            var transactions = searchTransactionsUseCase.Execute(
                transactionViewModel.CashierName,
                transactionViewModel.StartDate,
                transactionViewModel.EndDate);

            transactionViewModel.Transactions = transactions;
            return View("Index", transactionViewModel);
        }
    }
}
