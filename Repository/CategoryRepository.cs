using mvc_market.Interfaces;
using mvc_market.Models;

namespace mvc_market.Repository;

public class CategoryRepository : ICarsCategory
{

    private readonly AppDBContext appDBContext;

    public CategoryRepository(AppDBContext appDBContext)
    {
        this.appDBContext = appDBContext;
    }
    public IEnumerable<Category> AllCategories => appDBContext.Category;
}
