using Data.Repository.DataBase;
using Data.Model;
using Data.Repository.Repository.ProductRepo;
using Microsoft.EntityFrameworkCore;

namespace Data.Repository.ProductRepo
{
    public class ProductRepository : IProductRepository
    {
        private InventoryDbContext _inventoryDbContext;

        public ProductRepository(InventoryDbContext dBContext)
        {
            _inventoryDbContext = dBContext;
        }

        public Product GetProduct(int id)
        {
            var product = _inventoryDbContext.Products.FirstOrDefault(x => x.Id == id);

            return product;
        }

        public List<Product> GetAllProductsAsync()
        {
            var products = _inventoryDbContext.Products.ToListAsync();

            return products.Result;
        }

        public void AddProducts(Product product)
        {
            _inventoryDbContext.Products.Add(product);
            _inventoryDbContext.SaveChanges();
        }

        public void UpdateProduct(Product product)
        {
            _inventoryDbContext.SaveChanges();
        }
    }
}
