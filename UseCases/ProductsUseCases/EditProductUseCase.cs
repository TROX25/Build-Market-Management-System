using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;


namespace UseCases.ProductsUseCases
{
    public class EditProductUseCase
    {
        private readonly IProductRepository productRepository;
        public EditProductUseCase(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        public void Execute(CoreBusiness.Product product)
        {
            productRepository.UpdateProduct(product);
        }
    }
}
