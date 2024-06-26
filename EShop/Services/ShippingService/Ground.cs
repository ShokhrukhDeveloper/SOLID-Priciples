//----------------------------------------
// Tarteeb School (c) All rights reserved
//----------------------------------------

using EShop.Services.OrderService;

namespace EShop.Services.ShippingService
{
    public class Ground : IShippingService
    {
        public double GetCost(IOrderService order)
        {
            if (order.GetTotal() < 100)
            {
                return 0;
            }

            return Math.Max(10, order.GetTotalWeight() * 1.5);
        }

        public DateTimeOffset GetDate()
        {
            return DateTime.Now.AddDays(5);
        }
    }
}