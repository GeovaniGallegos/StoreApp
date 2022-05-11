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
    public class ProductService : IProductService
    {
        private readonly Context _context;
        public ProductService(Context context)
        {
            this._context = context;
        }
        public  void AddProduct(Product product)
        {
           _context.Products.Add(product);
           _context.SaveChanges();
        }

        public  void DeleteProduct(Guid id)
        {
            Product? result =  _context.Products
               .FirstOrDefault(p => p.Id == id);
            if (result != null)
            {
                _context.Products.Remove(result);
                _context.SaveChanges();
            }
        }

        public async Task<IEnumerable<Product>> GetAllProducts()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<Product> GetProductById(Guid id)
        {
            return await _context.Products.FirstOrDefaultAsync(p => p.Id == id);
        }

        public void UpdateProduct(Product product)
        {
             _context.Products.Update(product);
             _context.SaveChanges();

        }
    }
}
