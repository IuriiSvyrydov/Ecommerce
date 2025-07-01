using Microsoft.Extensions.DependencyInjection;
using Catalog.Core.Repositories;
using Catalog.Infrastructure.Repositories;

namespace Catalog.Infrastructure.Extensions;

public static class RegisterRepositoriesExtension
{
    public static IServiceCollection RegisterRepositories(this IServiceCollection services)
    {
        services.AddScoped<IProductRepository, ProductRepository>();
        services.AddScoped<IBrandRepository, ProductRepository>();
        services.AddScoped<ITypeRepository, ProductRepository>();
        return services;
    }
}