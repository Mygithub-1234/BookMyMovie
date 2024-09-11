using BookMyMovie.Services;
using Microsoft.AspNetCore.Mvc;
using System.Net;

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

        //[HttpGet]
        //public Task<HttpStatusCode> SendNotification()
        //{
        //    try
        //    {
        //        var result = _NotificationService.SendNotification();
        //        return result;
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}

    }
}
