using AzureCleanArch.Application.Abstractions.Repositories;
using AzureCleanArch.Core.Domain;

namespace AzureCleanArch.Infrastructure.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        public async Task<Order?> Get(Guid id)
        {
            // it would be replaced by a query, for example EF DbContext.DbSet
            return await Task.FromResult(new Order { Id = Guid.NewGuid(), Items = [] });
        }
    }
}
