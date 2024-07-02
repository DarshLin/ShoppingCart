using ShoppingCart;
using ShoppingCart.Services;

namespace ShoppingCartTests.Services
{
    public class CartServiceTests
    {
        [Fact]
        public void AddItem_WithNull_ThrowsArgumentNullException()
        {
            var cartService = new CartService();
            Assert.Throws<ArgumentNullException>(() => cartService.AddItem(null));
        }

        [Fact]
        public void AddItem_WithValidCartItem_ItemInCart()
        {
            var cartService = new CartService();
            var item = new CartItem { Name = "Test", Price = 1.50m, Quantity = 2 };
            cartService.AddItem(item);

            var items = cartService.ViewItems();

            Assert.Contains(item, items);
        }

        [Fact]
        public void ViewItems_Add2Items_ReturnsItemsAdded()
        {
            var cartService = new CartService();
            var item1 = new CartItem { Name = "Test1", Price = 1.50m, Quantity = 2 };
            var item2 = new CartItem { Name = "Test2", Price = 6.30m, Quantity = 5 };

            cartService.AddItem(item1);
            cartService.AddItem(item2);

            var items = cartService.ViewItems();

            Assert.Contains(item1, items);
            Assert.Contains(item2, items);
        }

    }
}
