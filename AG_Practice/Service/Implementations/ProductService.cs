using System;
using System.Collections.Generic;
using System.Linq;
using AG_Practice.Models;
using AG_Practice.Repository;

namespace AG_Practice.Service.Implementations
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;

        public ProductService(IProductRepository repository)
        {
            this._repository = repository;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            throw new NotImplementedException();
        }

        public ProductDto GetProduct(int productId)
        {
            var product = _repository.GetProduct(productId);

            return new ProductDto()
            {
                Name = product.Name,
                Color = product.Color,
                ListPrice = product.ListPrice,
                ProductNumber = product.ProductNumber
            };
        }

        public IEnumerable<ProductCategoryDto> GetParentProductCategories()
        {
            return _repository.SelectParentProductCategories().Select(x => new ProductCategoryDto()
                {
                    ProductCategoryId = x.ProductCategoryID,
                    Name = x.Name
                });
        }
    }
}