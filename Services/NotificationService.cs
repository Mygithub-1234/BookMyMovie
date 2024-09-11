using BookMyMovie.Models;
using BookMyMovie.Repository;
using System.Net;

namespace BookMyMovie.Services
{
    public class NotificationService 
    {
        //private readonly INotificationRepository _NotificationRepository;

        public NotificationService(INotificationRepository NotificationRepository, IEventBus eventBus)

        {
            //_NotificationRepository = NotificationRepository;
            eventBus.Subscribe<BookingDto>(HandleBookingCreated);
        }

        private void HandleBookingCreated(BookingDto bookingRequest)
        {
            // Logic to send notification
            Console.WriteLine($"Notification sent for booking dated: {bookingRequest.BookingDate}");
        }
    }
}
