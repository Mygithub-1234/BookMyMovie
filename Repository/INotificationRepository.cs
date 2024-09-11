using System.Net;

namespace BookMyMovie.Repository
{
    public interface INotificationRepository
    {
        Task<HttpStatusCode> SendNotification();
    }
}
