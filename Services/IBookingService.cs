using Microsoft.AspNetCore.Http.HttpResults;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using System.Threading.Channels;
using BookMyMovie.Models;

namespace BookMyMovie.Services
{
    public interface IBookingService
    {
        IEnumerable<Booking> GetByUserId(int userId);
        Booking? GetByBookingId(int bookingId);
        void CreateBooking(BookingDto booking);
        void UpdateBooking(int bookingId);//cancel or modify
        void DeleteBooking(int bookingId);
    }
}
