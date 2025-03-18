using Data.Model;

namespace Data.Repository.Repository.CategoryRepo
{
    public interface ICategoryRepository
    {
        Category GetCategory(int id);

        List<Category> GetAllCategories();

        void AddCategory(Category category);

        void UpdateCategory(Category category);
    }
}
