using System.Collections.Generic;
using System.Linq;
using BlazingShop.Data;

namespace BlazingShop.Services
{
    public class CategoryService
    {
        private readonly ApplicationDbContext _dbContext;
        public CategoryService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Category GetCategory(int id)
        {
            return _dbContext.Categories.FirstOrDefault(c => c.Id == id);
        }

        public List<Category> GetCategories()
        {
            return _dbContext.Categories.ToList();
        }

        public bool CreateCategory(Category objCategory)
        {
            _dbContext.Categories.Add(objCategory);
            return _dbContext.SaveChanges() > 0;
        }

        public bool UpdateCategory(Category objCategory)
        {
            var dbCategory = _dbContext.Categories.FirstOrDefault(c => c.Id == objCategory.Id);
            if (dbCategory != null)
            {
                dbCategory.Name = objCategory.Name ?? dbCategory.Name;
                _dbContext.Categories.Update(dbCategory);
                return _dbContext.SaveChanges() >= 0;
            }
            return false;
        }

        public bool DeleteCategory(Category objCategory)
        {
            var dbCategory = _dbContext.Categories.FirstOrDefault(c => c.Id == objCategory.Id);
            if (dbCategory != null)
            {
                _dbContext.Categories.Remove(dbCategory);
                return _dbContext.SaveChanges() > 0;
            }
            return false;
        }


    }
}