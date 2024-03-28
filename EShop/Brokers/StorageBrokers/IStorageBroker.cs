//----------------------------------------
// Tarteeb School (c) All rights reserved
//----------------------------------------

namespace EShop.Brokers.Storages
{
    public interface IStorageBroker<T> where T : class
    {
        List<T> GetAll();
        T Add(T credential);
        
    }
}