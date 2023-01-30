using Eshop.Application.Sales;
using Eshop.ViewModels.Sales;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eshop.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        public readonly ICartService _cartService;
        public CartController(ICartService cartService)
        {
            _cartService = cartService;
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> CreatePurchase([FromBody] CheckoutRequest request)
        {

            var products = await _cartService.CreatePurchase(request);
            return Ok(products);
        }
    }
}
