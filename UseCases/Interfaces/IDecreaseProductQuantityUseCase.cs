namespace UseCases.Interfaces
{
    public interface IDecreaseProductQuantityUseCase
    {
        void Execute(int productId, int quantity);
    }
}