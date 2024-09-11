using BookMyMovie.Models;
using BookMyMovie.Services;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using System.Threading.Channels;
using Microsoft.AspNetCore.Authorization;

namespace BookMyMovie.Controllers
{
    [Route("api/v1.0/[controller]/")]
    [ApiController]
    //Authorize]
    public class BookingController : Controller
    {
        private readonly IBookingService _bookingService;
        public BookingController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }

        /// <summary>
        /// Creates new booking
        /// </summary>
        /// <param name="booking"></param>
        [HttpPost("NewBooking")]
        public IActionResult CreateBooking(BookingDto booking)
        {
            try
            {
                _bookingService.CreateBooking(booking);
                return Ok("Booking created and event published.");
            }
            catch (Exception)
            {

                throw;
            }

        }

        /// <summary>
        /// Cancels a booking
        /// </summary>
        /// <param name="bookingId"></param>
        [HttpDelete("CancelBooking")]
        public void DeleteBooking(int bookingId)
        {
            try
            {
                _bookingService.DeleteBooking(bookingId);
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// Gets booking details by bookingId
        /// </summary>
        /// <param name="bookingId"></param>
        /// <returns></returns>
        [HttpGet("GetBookingsByBookingId")]
        public Booking? GetByBookingId(int bookingId)
        {
            try
            {
                var result = _bookingService.GetByBookingId(bookingId);
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// Gets booking details for a User
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpGet("GetBookingByUserId")]
        public IEnumerable<Booking> GetByUserId(int userId)
        {
            try
            {
                var result = _bookingService.GetByUserId(userId);
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// Modifies a booking based on bookingId
        /// </summary>
        /// <param name="bookingId"></param>
        [HttpPut("UpdateBooking")]
        public void UpdateBooking(int bookingId)
        {
            try
            {
                _bookingService.UpdateBooking(bookingId);

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
