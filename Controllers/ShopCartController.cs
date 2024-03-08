using Microsoft.AspNetCore.Mvc;
using mvc_market.Interfaces;
using mvc_market.Models;
using mvc_market.ViewModels;

namespace mvc_market.Controllers;

public class ShopCartController : Controller
{
    private IAllCars _carRep;
    private readonly ShopCart _shopCart;

    public ShopCartController(IAllCars carRep, ShopCart shopCart)
    {
        _carRep = carRep;
        _shopCart = shopCart;
    }

    public ViewResult Index()
    {
        var items = _shopCart.GetShopItems();
        _shopCart.ListShopItems = items;

        var obj = new ShopCartViewModel
        {
            shopCart = _shopCart
        };

        return View(obj);
    }

    public RedirectToActionResult addToCart(int id)
    {
        var item = _carRep.Cars.FirstOrDefault(i => i.Id == id);
        if (item != null)
        {
            _shopCart.AddToCart(item);
        }
        return RedirectToAction("Index");
    }

    public RedirectToActionResult RemoveFromCart(int id)
    {
        var item = _carRep.Cars.FirstOrDefault(i => i.Id == id);
        if (item != null)
        {
            _shopCart.RemoveFromCart(item);
        }
        return RedirectToAction("Index");
    }
}
