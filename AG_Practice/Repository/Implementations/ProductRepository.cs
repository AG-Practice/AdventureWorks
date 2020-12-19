using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using Unity;


namespace AG_Practice.Repository
{
    public class ProductRepository : IProductRepository
    {
        [Unity.Dependency]
        public ProductContext DbContext { get; set; }

        public IEnumerable<Product> GetAllProducts()
        {
            throw new NotImplementedException();
        }

        public Product GetProduct(int productId)
        {
            return DbContext
                .Products
                .Single(x => x.ProductID == productId);
        }

        public IEnumerable<ProductCategory> SelectParentProductCategories()
        {
            return DbContext
                .ProductCategories
                .Where(x => x.ParentProductCategoryID == null);
        }
    }
}