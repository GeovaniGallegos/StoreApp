using Domain.RepositoryInterfaces;
using Microsoft.Extensions.DependencyInjection;
using Persistance.Repository;
using Services.ServicesInterfaces;

namespace Services
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {

            services.AddScoped<IStoreRepository, StoreRespository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IStoreService, StoreService>();
            return services;
        }
    }
}
