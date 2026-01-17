using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;
using UseCases.Interfaces;

namespace UseCases.ProductsUseCases
{
    public class DecreaseProductQuantityUseCase : IDecreaseProductQuantityUseCase
    {
        private readonly IProductRepository productRepository;

        public DecreaseProductQuantityUseCase(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public void Execute(int productId, int quantity)
        {
            productRepository.DecreaseProductQuantity(productId, quantity);
        }
    }
}
