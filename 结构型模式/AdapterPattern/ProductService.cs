using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdapterPattern
{
    public class ProductService
    {
        //依赖倒置原则
        private IProductRepository _productRepository;

        private ICacheStorage _cacheStorage;

        //依赖注入
        public ProductService(IProductRepository productRepository,ICacheStorage cacheStorage)
        {
            _productRepository = productRepository;
            _cacheStorage = cacheStorage;
        }

        //缓存处理
        public IList<Product> GetAllProducts(int categoryId)
        {
            IList<Product> products ;
            string storageKey = "ProductsByCategoryId " + categoryId;
            products = _cacheStorage.Retrieve<List<Product>>(storageKey);
            if (products == null)
            {
                products = _productRepository.GetAllProducts(categoryId);
                _cacheStorage.Store(storageKey, products);
            }
               

            return products;
        }
    }
}
