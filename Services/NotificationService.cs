using BookMyMovie.Repository;

namespace BookMyMovie.Services
{
    public class NotificationService : INotificationService
    {
        private readonly INotificationRepository _NotificationRepository;

        public NotificationService(INotificationRepository NotificationRepository)

        {
            _NotificationRepository = NotificationRepository;
        }
        public void SendNotification()
        {
            _NotificationRepository.SendNotification();
        }
    }
}
