using DiPatternDemo.Data;
using DiPatternDemo.Models;

namespace DiPatternDemo.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext db;
        public CategoryRepository(ApplicationDbContext db)
        {
            this.db = db;
        }
        public int AddCategory(Category category)
        {
            int result = 0;
            db.Categories.Add(category);
            result = db.SaveChanges();
            return result;
        }

        public int DeleteCategory(int id)
        {
            int result = 0;
            var c=db.Categories.Where(x=> x.CategoryId == id).SingleOrDefault();
            if(c != null)
            {
                db.Categories.Remove(c);
                result = db.SaveChanges();
            }
            return result;
        }

        public IEnumerable<Category> GetCategories()
        {
            return db.Categories.ToList();
        }

        public Category GetCategoryById(int id)
        {
            return db.Categories.Where(x => x.CategoryId == id).SingleOrDefault();
        }

        public int UpdateCategory(Category category)
        {
            int result = 0;
            var c=db.Categories.Where(x=> x.CategoryId==category.CategoryId).SingleOrDefault();
            if(c != null)
            {
                c.CategoryName = category.CategoryName;
                result = db.SaveChanges();
            }
            return result;
        }
    }
}

