using DiPatternDemo.Models;

namespace DiPatternDemo.Services
{
    public interface ICategoryService
    {
        IEnumerable<Category> GetCategories();
        Category GetCategoryById(int id);
        int AddCategory(Category category);
        int UpdateCategory(Category category);
        int DeleteCategory(int id);
    }
}
