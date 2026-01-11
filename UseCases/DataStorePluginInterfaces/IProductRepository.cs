using CoreBusiness;

namespace UseCases.DataStorePluginInterfaces
{
    public interface IProductRepository
    {
        void AddProduct(Product product);
        void DecreaseProductQuantity(int productId, int quantity);
        void DeleteProduct(int productId);
        Product GetProductById(int productId);
        IEnumerable<Product> GetProducts(bool loadCategory);
        IEnumerable<Product> GetProductsByCategoryId(int categoryId);
        void UpdateProduct(Product product);
    }
}