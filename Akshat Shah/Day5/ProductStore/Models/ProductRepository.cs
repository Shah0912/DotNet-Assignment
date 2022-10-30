using ProductStore.DataAccessLayer;

namespace ProductStore.Models
{
    public class ProductRepository : IProductRepository
    {
        ProductsDataLayer productsDataLayer;

        private int _nextId = 1;

        public ProductRepository()
        {
            productsDataLayer = new ProductsDataLayer();
        }

        public Product AddProduct(Product product)
        {
            if (product == null)
            {
                throw new ArgumentNullException(nameof(product));
            }
            product.Id = _nextId++;
            productsDataLayer.Products.Add(product);
            productsDataLayer.SaveChanges();
            return product;
        }

        public Product Get(int id)
        {
            return productsDataLayer.Products.ToList().Find(product => product.Id == id);    
        }

        public IEnumerable<Product> GetAll()
        {
            return productsDataLayer.Products.ToList();
        }

        public void Remove(int id)
        {
            Product found = productsDataLayer.Products.Find(product => product.Id == id);
            if (found == null)
            {
                throw new ArgumentException("Product not found");
            }
            productsDataLayer.Products.Remove(found);
            productsDataLayer.SaveChanges();
        }

        public bool Update(Product product)
        {
            if (product == null)
            {
                throw new ArgumentNullException("product");
            }

            Product found = productsDataLayer.Products.Find(_product => _product.Id == product.Id);
            if (found == null)
            {
                return false;
            }

            found.Name = product.Name;
            found.Category = product.Category;
            found.Price = product.Price;
            productsDataLayer.SaveChanges();
            return true;
        }
    }
}
