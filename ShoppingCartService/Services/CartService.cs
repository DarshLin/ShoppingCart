using ShoppingCart.Items;

namespace ShoppingCart.Services
{
    /// <summary>
    /// The cart service
    /// </summary>
    public class CartService : ICartService
    {
        private readonly Cart _cart = new Cart();

        /// <summary>
        /// Add item to cart
        /// </summary>
        /// <param name="item">The item</param>
        /// <exception cref="ArgumentNullException"></exception>
        public void AddItem(CartItem item)
        {
            if (item is null) { 
                throw new ArgumentNullException("add item");
            }

            _cart.AddItem(item);
        }

        /// <summary>
        /// View items in cart
        /// </summary>
        /// <returns>cart items</returns>
        public IEnumerable<CartItem> ViewItems()
        {
            return _cart.ViewItems();
        }
    }
}
