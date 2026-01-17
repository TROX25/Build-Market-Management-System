using CoreBusiness;

namespace UseCases.Interfaces
{
    public interface IRecordTransactionUseCase
    {
        void Execute(Transaction transaction);
    }
}