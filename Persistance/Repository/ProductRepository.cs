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
    public class ProductRepository : IProductRepository
    {
        private readonly Context _context;
        public ProductRepository(Context context)
        {
            this._context = context;
        }
        public void Create(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public void Delete(Guid id)
        {
            Product? result = _context.Products
              .FirstOrDefault(p => p.Id == id);
            if (result != null)
            {
                _context.Products.Remove(result);
                _context.SaveChanges();
            }
        }

        public async Task<IEnumerable<Product>> FindAll()
        {
            return await _context.Products.ToListAsync(); ;
        }

        public async Task<Product> FindById(Guid id)
        {
            return await _context.Products.FirstOrDefaultAsync(p => p.Id == id);
        }

        public void Update(Product product)
        {
            _context.Products.Update(product);
            _context.SaveChanges();
        }


    }
}
