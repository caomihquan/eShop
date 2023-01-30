using Eshop.Data.EF;
using Eshop.ViewModels.Sales;
using Eshop.Webapp.Models;
using eShopSolution.Data.Entities;
using eShopSolution.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Eshop.Application.Sales
{
    public class CartService : ICartService
    {
        private readonly EshopDbContext _context;


        public CartService(EshopDbContext context)
        {
            _context = context;
        }
        public async Task<int> CreatePurchase(CheckoutRequest request)
        {
            var orderDetails = new List<OrderDetail>();
            foreach (var item in request.OrderDetails)
            {
                orderDetails.Add(new OrderDetail()
                {
                    ProductId = item.ProductId,
                    Quantity = item.Quantity,
                });
            }
            var order = new Order()
            {
                OrderDate = DateTime.Now,
                ShipName = request.Name,
                ShipAddress = request.Address,
                ShipEmail = request.Email,
                ShipPhoneNumber = request.PhoneNumber,
                Status = OrderStatus.InProgress,
                OrderDetails = orderDetails,
                UserId = new Guid("EB3A185B-061A-492D-E4D8-08DAFF77C5DE")
            };
            
            _context.Orders.Add(order);         
            await _context.SaveChangesAsync();
            return order.Id;
        }
    }
}
