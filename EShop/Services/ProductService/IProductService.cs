//----------------------------------------
// Tarteeb School (c) All rights reserved
//----------------------------------------

using EShop.Models;

namespace EShop.Services.Storage
{
    public interface IProductService
    {
        void PrintAllProducts();
        void AddToCart(Product product);
        Product GetProductByIndex(int index);
        public Product Add(Product product);
        public List<Product> GetAllCart();
    }
}