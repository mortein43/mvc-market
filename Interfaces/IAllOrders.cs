using mvc_market.Models;

namespace mvc_market.Interfaces;

public interface IAllOrders
{
    void createOrder(Order order);
}
