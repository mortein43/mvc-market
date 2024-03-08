using mvc_market.Models;

namespace mvc_market.Interfaces;

public interface ICarsCategory
{
    IEnumerable<Category> AllCategories { get; }
}
