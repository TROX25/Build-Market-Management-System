using CoreBusiness;
using UseCases.DataStorePluginInterfaces;

namespace Plugins.DataStore.InMemory
{
    public class CategoriesInMemoryRepository : ICategoryRepository
    {
        private List<Category> _categories = new List<Category>()
        {
            new Category { ID = 1, Name = "Beverage", Description = "Beverage" },
            new Category { ID = 2, Name = "Bakery", Description = "Bakery" },
            new Category { ID = 3, Name = "Meat", Description = "Meat" }
        };

        public void AddCategory(Category category)
        {
            if (_categories != null && _categories.Count > 0)
            {
                var maxId = _categories.Max(x => x.ID);
                category.ID = maxId + 1;
            }
            else
            {
                category.ID = 1;
            }
            if (_categories == null)
            {
                new List<Category>();
            }
            if (_categories == null) _categories = new List<Category>();
            _categories.Add(category);
        }

        public IEnumerable<Category> GetCategories() => _categories;

        public Category? GetCategoryById(int ID)
        {
            var category = _categories.FirstOrDefault(x => x.ID == ID);
            if (category != null)
            {
                return new Category
                {
                    ID = category.ID,
                    Name = category.Name,
                    Description = category.Description,
                };
            }

            return null;
        }

        public void UpdateCategory(int ID, Category category)
        {
            if (ID != category.ID) return;

            var categoryToUpdate = _categories.FirstOrDefault(x => x.ID == ID);
            if (categoryToUpdate != null)
            {
                categoryToUpdate.Name = category.Name;
                categoryToUpdate.Description = category.Description;
            }
        }

        public void DeleteCategory(int ID)
        {
            var category = _categories.FirstOrDefault(x => x.ID == ID);
            if (category != null)
            {
                _categories.Remove(category);
            }
        }
    }
}
