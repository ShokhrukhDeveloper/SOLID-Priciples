//----------------------------------------
// Tarteeb School (c) All rights reserved
//----------------------------------------

using EShop.Models;
using EShop.Services.OrderService;
using EShop.Services.ShippingService;

namespace EShop.Services.Order
{
    public class OrderService : IOrderService
    {        
        private IList<Product> lineItems;
        private IShippingService shipping;

        public OrderService(IList<Product> products) =>
            lineItems = products;


        public int GetTotal() => lineItems.Count;
        public double GetTotalWeight() => lineItems.Sum(x => x.Weight);
        public void SetShippingType(IShippingService shippingType) => 
            shipping = shippingType;
        
        public double GetShippingCost()
        {
            return shipping.GetCost(this);
        }
        public DateTimeOffset GetShippingDate() => DateTime.Now;
    }
}