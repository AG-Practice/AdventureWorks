using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AG_Practice.Domain.Interfaces;

namespace AG_Practice.Repository
{
    public class ProductRepository : IProductRepository
    {
        public IEnumerable<Product> GetAllProducts()
        {
            throw new NotImplementedException();
        }

        public Product GetProduct(int productId)
        {
            Product product;
            using(var context = new ProductContext())
            {
                product = context.Products.Single(x => x.ProductID == productId);
            }

            return product;
        }
    }
}