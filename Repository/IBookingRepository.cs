using BookMyMovie.Models;
using BookMyMovie.Services;

namespace BookMyMovie.Repository
{
    public interface IBookingRepository
    {
        IEnumerable<Booking> GetByUserId(int userId);
        Booking? GetByBookingId(int bookingId);
        Booking? CreateBookingAndSendEvent(BookingDto booking);
        void UpdateBooking(int bookingId);//cancel or modify
        void DeleteBooking(int bookingId);
    }
}
