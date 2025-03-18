using Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository.Repository.ProductRepo
{
    public interface IProductRepository
    {
        Product GetProduct(int id);

        List<Product> GetAllProducts();

        void AddProducts(Product product);

        void UpdateProduct(Product product);
    }
}
