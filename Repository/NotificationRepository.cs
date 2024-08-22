using Azure.Messaging.ServiceBus;
using BookMyMovie.DB;
using Microsoft.AspNetCore.Mvc;

namespace BookMyMovie.Repository
{
    public class NotificationRepository : INotificationRepository
    {
        private readonly MovieDBContext _context;
        private readonly string _connectionString;
        private readonly string _queueName;

        public NotificationRepository(MovieDBContext context, IConfiguration configuration)
        {
            _context = context;
            _connectionString = configuration.GetSection("ServiceBus:ConnectionString").Value;
            _queueName = configuration.GetSection("ServiceBus:QueueName").Value;
        }
        public async Task SendNotification()
        {
            await using var client = new ServiceBusClient(_connectionString);
            ServiceBusReceiver receiver = client.CreateReceiver(_queueName);

            try
            {
                ServiceBusReceivedMessage message = await receiver.ReceiveMessageAsync();

                if (message != null)
                {
                    string messageBody = message.Body.ToString();
                    await receiver.CompleteMessageAsync(message);
                 }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

    }
}
