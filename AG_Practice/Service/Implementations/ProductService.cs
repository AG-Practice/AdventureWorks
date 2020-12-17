﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AG_Practice.Service
{
    public class ProductService : ProductContext, IProductService
    {
        public IEnumerable<Product> GetAllProducts()
        {
            throw new NotImplementedException();
        }

        public Product GetProduct(int productId)
        {
            Product product;
            using (var context = new ProductContext())
            {
                product = context.Products.Single(x => x.ProductID == productId);
            }

            return product;
        }
    }
}