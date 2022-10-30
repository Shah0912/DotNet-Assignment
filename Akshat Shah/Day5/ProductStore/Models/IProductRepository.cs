namespace ProductStore.Models
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAll();
        Product Get(int id);    
        Product AddProduct(Product product);
        void Remove(int id);
        bool Update(Product product);
    }
}
