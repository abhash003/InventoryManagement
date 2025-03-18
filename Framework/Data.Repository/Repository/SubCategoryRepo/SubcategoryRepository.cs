using Data.Model;
using Data.Repository.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository.Repository.SubCategoryRepo
{
    public class SubcategoryRepository : ISubcategoryRepository
    {
        private InventoryDbContext _inventoryDbContext;

        public SubcategoryRepository(InventoryDbContext dBContext)
        {
            _inventoryDbContext = dBContext;
        }

        public SubCategory GetSubCategory(int id)
        {
            var subCategory = _inventoryDbContext.SubCategories.FirstOrDefault(x => x.SubCategoryId == id);

            return subCategory;
        }

        public List<SubCategory> GetAllSubCategories()
        {
            var subCategory = _inventoryDbContext.SubCategories.ToList();

            return subCategory;
        }

        public void AddSubCategory(SubCategory subCategory)
        {
            _inventoryDbContext.SubCategories.Add(subCategory);
            _inventoryDbContext.SaveChanges();
        }

        public void UpdateSubCategory(SubCategory subCategory)
        {
            _inventoryDbContext.SaveChanges();
        }
    }
}
