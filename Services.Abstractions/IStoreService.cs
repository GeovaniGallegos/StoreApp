using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Abstractions
{
    public interface IStoreService
    {
        Task<Store> GetStoreById();
        Task<IEnumerable<Store>> GetAllStores();
        void AddStore(Store store);
        void UpdateStore(Store store);
        void DeleteStore(Store store);
        
    }
}
