using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistance;
using Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class StoreService : IStoreService
    {
        private readonly Context _context;
        public StoreService(Context context)
        {
            this._context = context;
        }

        public void AddStore(Store store)
        {
            _context.Stores.Add(store);
            _context.SaveChanges();
        }

        public void DeleteStore(Guid id)
        {
            Store? result = _context.Stores
              .FirstOrDefault(p => p.Id == id);
            if (result != null)
            {
                _context.Stores.Remove(result);
                _context.SaveChanges();
            }
        }

        public async  Task<IEnumerable<Store>> GetAllStores()
        {
            return await _context.Stores.Include("Stocks").ToListAsync();
        }

        public async Task<Store> GetStoreById(Guid id)
        {
            return await _context.Stores.Include("Stocks").FirstOrDefaultAsync(p => p.Id == id);
        }

        public void UpdateStore(Store store)
        {
            _context.Stores.Update(store);
            _context.SaveChanges();
        }
    }
}
