using AzureCleanArch.Core.Domain;

namespace AzureCleanArch.Application.Abstractions.Repositories;
public interface IOrderRepository
{
    Task<Order?> Get(Guid id);
}
