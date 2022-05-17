using Domain.Entities;
using Domain.RepositoryInterfaces;
using Microsoft.EntityFrameworkCore;
using Persistance;
using Services.ServicesInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class StoreService : IStoreService
    {
        private readonly IStoreRepository _storeRepository;
        public StoreService(IStoreRepository storeRepository)
        {
            this._storeRepository = storeRepository;
        }

        public void AddStore(Store store)
        {
            _storeRepository.Create(store);

        }

        public void DeleteStore(Guid id)
        {
            _storeRepository.Delete(id);
        }

        public async Task<IEnumerable<Store>> GetAllStores()
        {
            return await _storeRepository.FindAll();
        }

        public async Task<Store> GetStoreById(Guid id)
        {
            return await _storeRepository.FindById(id);
        }

        public void UpdateStore(Store store)
        {
            _storeRepository.Update(store);
        }
    }
}
