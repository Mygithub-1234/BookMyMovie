using Azure.Messaging.ServiceBus;
using BookMyMovie.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace BookMyMovie.Repository
{
    public class NotificationRepository : INotificationRepository
    {
        private readonly MovieReserveContext _context;
        private readonly string _connectionString;
        private readonly string _queueName;

        public NotificationRepository(MovieReserveContext context, IConfiguration configuration)
        {
            _context = context;
            _connectionString = configuration.GetSection("ServiceBus:ConnectionString").Value;
            _queueName = configuration.GetSection("ServiceBus:QueueName").Value;
        }
        public async Task<HttpStatusCode> SendNotification()
        {
            await using var client = new ServiceBusClient(_connectionString);
            ServiceBusReceiver receiver = client.CreateReceiver(_queueName);

            ServiceBusReceivedMessage message = await receiver.ReceiveMessageAsync();

            if (message != null)
            {
                string messageBody = message.Body.ToString();
                await receiver.CompleteMessageAsync(message);
                return HttpStatusCode.OK;
            }
            else
            {
                return HttpStatusCode.NotFound;
            }

        }

    }
}
