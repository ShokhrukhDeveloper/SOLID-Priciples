using EShop.Brokers.Storages;
using EShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Brokers.StorageBrokers.FileBroker
{
    internal interface IFileStorageBroker : IStorageBroker<Credential>
    {
    }
}
