using Eshop.ViewModels.Sales;
using Eshop.Webapp.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Eshop.Application.Sales
{
    public interface ICartService
    {
        Task<int> CreatePurchase(CheckoutRequest request);

    }
}
