using Microsoft.AspNetCore.Mvc;

namespace Build_Market_Management_System.Models.ViewComponents
{
    [ViewComponent]
    public class TransactionsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(string userName)
        {
            var transactions = TransactionsRepository.GetByDayAndCashier(userName, DateTime.Now);
            return View(transactions);
        }

         
    }
}
