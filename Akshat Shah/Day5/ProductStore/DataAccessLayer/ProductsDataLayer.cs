using System;
using ProductStore.Models;

namespace ProductStore.DataAccessLayer
{
    public class ProductsDataLayer
    {
        public List<Product> Products { get; set; }

        public ProductsDataLayer()
        {
            Products = new List<Product>();
        }

        public void SaveChanges()
        {
            return;
        }
    }
}
