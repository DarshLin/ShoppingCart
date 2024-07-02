using Microsoft.AspNetCore.Mvc;
using ShoppingCart.Services;

namespace ShoppingCart.Controllers
{
    /// <summary>
    /// The shopping cart controller
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class ShoppingCartController : ControllerBase
    {
        private readonly ICartService _cartService;

        public ShoppingCartController(ICartService cartService) 
        {
            _cartService = cartService;
        }


        /// <summary>
        /// Add item to cart
        /// </summary>
        /// <param name="item">The item</param>
        [HttpPost("AddItem")]
        public ActionResult AddItem(CartItem item)
        {
            _cartService.AddItem(item);

            return Ok();
        }

        /// <summary>
        /// View items in cart
        /// </summary>
        /// <returns>List of items in cart</returns>
        [HttpGet("ViewItems")]
        public IEnumerable<CartItem> ViewItems()
        {
            return _cartService.ViewItems();
        }
    }
}
