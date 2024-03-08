using mvc_market.Models;

namespace mvc_market.Interfaces;

public interface IAllCars
{
    IEnumerable<Car> Cars { get; }
    IEnumerable<Car> getFavCars { get; }
    Car getObjectCars(int carId);
    void AddCar(Car car);
    void RemoveCar(int carId);
}
