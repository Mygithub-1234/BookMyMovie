using BookMyMovie.Services;
using BookMyMovie.Models;

namespace BookMyMovie.Services
{
    public class InventoryService
    {
        public InventoryService(IEventBus eventBus)
        {
            eventBus.Subscribe<OrderCreatedEvent>(HandleOrderCreated);
        }

        private void HandleOrderCreated(OrderCreatedEvent orderCreatedEvent)
        {
            // Logic to update inventory
            Console.WriteLine($"Inventory updated for OrderId: {orderCreatedEvent.OrderId}");
        }
    }

}
