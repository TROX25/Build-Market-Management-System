using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreBusiness;
using UseCases.DataStorePluginInterfaces;

namespace Plugins.DataStore.SQL
{
    public class CategorySQLRepository : ICategoryRepository
    {
        private readonly MarketContext db;

        public CategorySQLRepository(MarketContext db)
        {
            this.db = db;
        }

        public void AddCategory(Category category)
        {
            // Add nie jest moim kodem tylko kodem EF
            db.Categories.Add(category);
            db.SaveChanges();
        }

        public void DeleteCategory(int categoryId)
        {
            if (categoryId <= 0) return;
            var categoryToDelete = db.Categories.FirstOrDefault(c => c.ID == categoryId);
            if (categoryToDelete != null)
            {
                // Remove nie jest moim kodem tylko kodem EF
                db.Categories.Remove(categoryToDelete);
                db.SaveChanges();
            }
        }

        public IEnumerable<Category> GetCategories()
        {
            return db.Categories.ToList();
        }

        public Category? GetCategoryById(int categoryId)
        {
            return db.Categories.Find(categoryId);
        }

        public void UpdateCategory(int categoryId, Category category)
        {
            if(categoryId != category.ID) return;
            var categoryToUpdate = db.Categories.FirstOrDefault(c => c.ID == categoryId);
            if (categoryToUpdate != null)
            {
                categoryToUpdate.Name = category.Name;
                categoryToUpdate.Description = category.Description;
                db.SaveChanges();
            }
        }
    }
}
