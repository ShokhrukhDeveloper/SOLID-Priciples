//----------------------------------------
// Tarteeb School (c) All rights reserved
//----------------------------------------

using EShop.Brokers.StorageBrokers.IMemoryBroker;
using EShop.Models;

namespace EShop.Services.Storage
{
    public class ProductService : IProductService
    {
        private readonly MemoryStorageBroker storageBroker;
        public ProductService()
        {
            storageBroker = new MemoryStorageBroker();
        }
        public void PrintAllProducts()
        {
            var products = storageBroker.GetAll();
            Console.WriteLine("--------Product-list-----------");
            int i = 0;
            foreach (Product product in products)
            {
                i++;
                Console.WriteLine($"{i}) {product.Name} - Weight: {product.Weight}");
            }
            Console.WriteLine("--------End-Of-Product-List-----------");
        }

        public List<Product> GetAllCart()
        {
            return storageBroker.GetAllCart();
        }

        public Product Add(Product product)
        {
            return storageBroker.Add(product);
        }

        public void AddToCart(Product product)
        {
            storageBroker.AddToCart(product);
        }

        public Product GetProductByIndex(int index)
        {
            return storageBroker.GetAll()[index];
        }
    }
}