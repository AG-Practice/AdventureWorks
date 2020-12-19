using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AG_Practice.Models;

namespace AG_Practice.Service
{
    public interface IProductService 
    {
        ProductDto GetProduct(int productId);
        IEnumerable<Product> GetAllProducts();
        IEnumerable<ProductCategoryDto> GetParentProductCategories();
    }
}
