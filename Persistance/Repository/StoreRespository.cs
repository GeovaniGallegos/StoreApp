using Domain.Entities;
using Domain.RepositoryInterfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Repository
{
    public class StoreRespository: IStoreRepository
    {
        private readonly Context _context;
        public StoreRespository(Context context)
        {
            this._context = context;
        }

        public void Create(Store store)
        {
            _context.Stores.Add(store);
            _context.SaveChanges();
        }

        public void Delete(Guid id)
        {
            Store? result = _context.Stores
             .FirstOrDefault(p => p.Id == id);
            if (result != null)
            {
                _context.Stores.Remove(result);
                _context.SaveChanges();
            }
        }

        public async Task<IEnumerable<Store>> FindAll()
        {
            return await _context.Stores.Include("Stocks").ToListAsync();
        }

        public async Task<Store> FindById(Guid id)
        {
            return await _context.Stores.Include("Stocks").FirstOrDefaultAsync(p => p.Id == id);
        }

        public void Update(Store store)
        {
            _context.Stores.Update(store);
            _context.SaveChanges();
        }
    }
}
