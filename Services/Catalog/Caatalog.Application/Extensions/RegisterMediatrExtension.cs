
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace Caatalog.Application.Extensions
{
    public static class RegisterMediatrExtension
    {
        public static IServiceCollection RegisterMediatr(this IServiceCollection services)
        {
            services.AddMediatR(options =>
            {
                options.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
            });
            return services;
        }
    }
}