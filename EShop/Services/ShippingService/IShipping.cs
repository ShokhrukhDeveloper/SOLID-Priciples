//----------------------------------------
// Tarteeb School (c) All rights reserved
//----------------------------------------

using EShop.Services.Order;
using EShop.Services.OrderService;

namespace EShop.Services.ShippingService
{
    public interface IShippingService
    {
        double GetCost(IOrderService order);
        DateTimeOffset GetDate();
    }
}