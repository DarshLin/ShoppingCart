using ShoppingCart.Items;

namespace ShoppingCart.Services
{
    /// <summary>
    /// The cart service interface
    /// </summary>
    public interface ICartService
    {

        /// <summary>
        /// Add item to cart
        /// </summary>
        /// <param name="item"></param>
        public void AddItem(CartItem item);

        /// <summary>
        /// View items in cart
        /// </summary>
        /// <returns></returns>
        public IEnumerable<CartItem> ViewItems();
    }
}
