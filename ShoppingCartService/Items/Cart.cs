namespace ShoppingCart.Items
{
    /// <summary>
    /// The Cart
    /// </summary>
    public class Cart
    {
        private readonly List<CartItem> _items = new List<CartItem>();
        /// <summary>
        /// The items
        /// </summary>
        public IEnumerable<CartItem> Items
        {
            get { return _items; }
        }

        /// <summary>
        /// Add an item
        /// </summary>
        /// <param name="item"></param>
        public void AddItem(CartItem item)
        {
            _items.Add(item);
        }

        /// <summary>
        /// View items
        /// </summary>
        /// <returns></returns>
        public IEnumerable<CartItem> ViewItems()
        {
            return _items;
        }

    }
}
