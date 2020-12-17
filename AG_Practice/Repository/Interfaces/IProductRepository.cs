using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AG_Practice.Repository
{
    public interface IProductRepository
    {
        Product GetProduct(int productId);
        IEnumerable<Product> GetAllProducts();
    }
}
