//----------------------------------------
// Tarteeb School (c) All rights reserved
//----------------------------------------

using EShop.Services.OrderService;

namespace EShop.Services.ShippingService
{
    public class Sea : IShippingService
    {
        public double GetCost(IOrderService order)
        {
            if (order.GetTotal() < 100)
            {
                return 0;
            }

            return Math.Max(15, order.GetTotalWeight() * 2);
        }

        public DateTimeOffset GetDate()
        {
            return DateTime.Now.AddDays(6);
        }
    }
}