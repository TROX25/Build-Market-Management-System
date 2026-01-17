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
    public class SearchTransactionsUseCase : ISearchTransactionsUseCase
    {
        private readonly ITransactionRepository trasactionRepository;

        public SearchTransactionsUseCase(ITransactionRepository trasactionRepository)
        {
            this.trasactionRepository = trasactionRepository;
        }

        public IEnumerable<Transaction> Execute(string cashierName, DateTime startDate, DateTime endDate)
        {
            return trasactionRepository.Search(cashierName, startDate, endDate);
        }
    }
}
