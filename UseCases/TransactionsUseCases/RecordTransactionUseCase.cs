using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.Interfaces;

namespace UseCases.TransactionsUseCases
{
    public class RecordTransactionUseCase
    {
        private readonly IRecordTransactionUseCase recordTransactionUseCase;

        public RecordTransactionUseCase(IRecordTransactionUseCase recordTransactionUseCase)
        {
            this.recordTransactionUseCase = recordTransactionUseCase;
        }

        public void Execute()
        {
            // Implementation for recording a transaction
        }
    }
}
