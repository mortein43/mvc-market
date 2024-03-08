using mvc_market.Models;

namespace mvc_market.ViewModels;

public class CarsListViewModel
{
    public IEnumerable<Car> allCars { get; set; }
    public string currCategory { get; set; }
}
