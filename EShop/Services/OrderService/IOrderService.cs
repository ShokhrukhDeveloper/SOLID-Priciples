//----------------------------------------
// Tarteeb School (c) All rights reserved
//----------------------------------------
using EShop.Services.ShippingService;

namespace EShop.Services.OrderService
{
    public interface IOrderService 
    {
        public int GetTotal();
        public double GetTotalWeight();
        public void SetShippingType(IShippingService shipping);
        public double GetShippingCost();
        public DateTimeOffset GetShippingDate();
    }
}
