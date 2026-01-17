using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreBusiness;
using UseCases.DataStorePluginInterfaces;
using UseCases.Interfaces;

namespace UseCases.TransactionsUseCases
{
    public class GetTodayTransactionUseCase : IGetTodayTransactionUseCase
    {
        private readonly ITransactionRepository trasactionRepository;

        public GetTodayTransactionUseCase(ITransactionRepository trasactionRepository)
        {
            this.trasactionRepository = trasactionRepository;
        }

        public IEnumerable<Transaction> Execute(string cashierName)
        {
            return trasactionRepository.GetByDayAndCashier(cashierName, DateTime.Now);
        }
    }
}
