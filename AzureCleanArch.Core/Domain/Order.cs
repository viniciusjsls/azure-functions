namespace AzureCleanArch.Core.Domain
{
    public class Order
    {
        public Guid Id { get; init; }
        public List<OrderItem> Items { get; private set; }
    }
}
