using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AG_Practice.Service
{
    public interface IProductService 
    {
        Product GetProduct(int productId);
        IEnumerable<Product> GetAllProducts();
    }
}
