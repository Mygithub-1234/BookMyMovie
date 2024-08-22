using BookMyMovie.Services;
using Microsoft.AspNetCore.Mvc;

namespace BookMyMovie.Controllers
{
    [Route("api/v1.0/[controller]/")]
    [ApiController]
    public class NotificationController : Controller
    {
        private readonly INotificationService _NotificationService;
        public NotificationController(INotificationService notificationService)
        {
            _NotificationService = notificationService;
        }

        [HttpGet]
        public void SendNotification()
        {
            try
            {
                _NotificationService.SendNotification();
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
