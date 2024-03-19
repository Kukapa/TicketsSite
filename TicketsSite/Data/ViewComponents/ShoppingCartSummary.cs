using Microsoft.AspNetCore.Mvc;
using TicketsSite.Data.Cart;

namespace TicketsSite.Data.ViewComponents
{
    [ViewComponent]
    public class ShoppingCartSummary
    {
        private readonly ShoppingCart _shoppingCart;
        public ShoppingCartSummary(ShoppingCart shoppingCart)
        {
            _shoppingCart = shoppingCart;
        }

        public IViewComponentResult Invoke()
        {
            var items = _shoppingCart.GetShoppingCartItems();

            return View(items.Count);
        }

        private IViewComponentResult View(int count)
        {
            throw new NotImplementedException();
        }
    }
}
