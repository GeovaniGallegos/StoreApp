using Domain.Entities;
using Domain.RepositoryInterfaces;
using Microsoft.EntityFrameworkCore;
using Persistance;
using Persistance.Repository;
using Services.ServicesInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            this._productRepository = productRepository;
        }
        public void AddProduct(Product product)
        {
            _productRepository.Create(product);
        }

        public void DeleteProduct(Guid id)
        {
            _productRepository.Delete(id);
        }

        public async Task<IEnumerable<Product>> GetAllProducts()
        {
            return await _productRepository.FindAll();
        }

        public async Task<Product> GetProductById(Guid id)
        {
            return await _productRepository.FindById(id);
        }

        public void UpdateProduct(Product product)
        {
            _productRepository.Update(product);

        }
    }
}
