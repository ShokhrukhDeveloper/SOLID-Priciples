//----------------------------------------
// Tarteeb School (c) All rights reserved
//----------------------------------------

using EShop.Services.OrderService;

namespace EShop.Services.ShippingService
{
    public class Air : IShippingService
    {
        public double GetCost(IOrderService order)
        {
            if (order.GetTotal() < 100)
            {
                return 0;
            }

            return Math.Max(20, order.GetTotalWeight() * 3);
        }

        public DateTimeOffset GetDate()
        {
            return DateTime.Now.AddDays(7);
        }
    }
}