using AzureCleanArch.Application.Abstractions.Repositories;
using AzureCleanArch.Application.UseCases.GetOrder;
using AzureCleanArch.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace AzureCleanArch.Infrastructure.DI
{
    public static class Startup
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddMediatR(cfg =>
            {
                cfg.RegisterServicesFromAssembly(typeof(GetOrderQueryHandler).Assembly);
            });
        }
    }
}
