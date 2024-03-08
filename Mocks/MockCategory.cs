using mvc_market.Interfaces;
using mvc_market.Models;

namespace mvc_market.Mocks;

public class MockCategory : ICarsCategory
{
    public IEnumerable<Category> AllCategories
    {
        get
        {
            return new List<Category>
            {
                new Category{Name = "Електромобілі"},
                new Category{Name = "Класичні авто"}
            };
        }
    }
}
