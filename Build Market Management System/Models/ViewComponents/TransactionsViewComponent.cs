using Microsoft.AspNetCore.Mvc;
using UseCases.Interfaces;
using UseCases.TransactionsUseCases;

namespace Build_Market_Management_System.Models.ViewComponents
{
    [ViewComponent]
    public class TransactionsViewComponent : ViewComponent
    {
        private readonly IGetTodayTransactionUseCase getTodayTransactionUseCase;

        public TransactionsViewComponent(IGetTodayTransactionUseCase getTodayTransactionUseCase)
        {
            this.getTodayTransactionUseCase = getTodayTransactionUseCase;
        }
        public IViewComponentResult Invoke(string userName)
        {
            var transactions = getTodayTransactionUseCase.Execute(userName);
            return View(transactions);
        }


    }
}
