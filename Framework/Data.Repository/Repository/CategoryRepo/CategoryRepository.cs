using Data.Model;
using Data.Repository.DataBase;

namespace Data.Repository.Repository.CategoryRepo
{
    public class CategoryRepository : ICategoryRepository
    {
        private InventoryDbContext _inventoryDbContext;

        public CategoryRepository(InventoryDbContext dBContext)
        {
            _inventoryDbContext = dBContext;
        }

        public Category GetCategory(int id)
        {
            var category = _inventoryDbContext.Categories.FirstOrDefault(x => x.CategoryId == id);

            return category;
        }

        public List<Category> GetAllCategories()
        {
            var categories = _inventoryDbContext.Categories.ToList();

            return categories;
        }

        public void AddCategory(Category category)
        {
            _inventoryDbContext.Categories.Add(category);
            _inventoryDbContext.SaveChanges();
        }

        public void UpdateCategory(Category category)
        {
            _inventoryDbContext.SaveChanges();
        }
    }
}
