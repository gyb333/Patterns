using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdapterPattern
{
    public class Product
    {
    }

    public interface IProductRepository
    {
        IList<Product> GetAllProducts(int categoryId);
    }

    public class ProductRepository : IProductRepository
    {

        public IList<Product> GetAllProducts(int categoryId)
        {
            IList<Product> products = new List<Product>();
            //......
            return products;
        }
    }
}
