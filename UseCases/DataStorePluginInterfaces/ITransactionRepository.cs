using CoreBusiness;

namespace UseCases.DataStorePluginInterfaces
{
    public interface ITransactionRepository
    {
        void AddTransaction(Transaction transaction);
        IEnumerable<Transaction> GetByDayAndCashier(string cashierName, DateTime now);
        IEnumerable<Transaction> Search(string cashierName, DateTime startDate, DateTime endDate);
    }
}