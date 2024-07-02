using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ShoppingCart.Items
{
    /// <summary>
    /// The item
    /// </summary>
    public class CartItem
    {
        /// <summary>
        /// The name
        /// </summary>
        [MinLength(1, ErrorMessage = "Item name must not be blank")]
        public required string Name { get; set; }

        /// <summary>
        /// The price
        /// </summary>
        [Range(0.01, double.MaxValue, ErrorMessage = "Price must be greater than 0")]
        public required decimal Price { get; set; }

        /// <summary>
        /// The quantity
        /// </summary>
        [DefaultValue(1)]
        [Range(1, int.MaxValue, ErrorMessage = "Quantity must be at least 1")]
        public required int Quantity { get; set; } = 1;

    }
}
