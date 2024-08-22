using BookMyMovie.Models;

namespace BookMyMovie.Repository
{
    public interface IBookingRepository
    {
        IEnumerable<Booking> GetByUserId(int userId);
        Booking? GetByBookingId(int bookingId);
        Task CreateBookingAndSendEvent(BookingDto booking);
        void UpdateBooking(int bookingId);//cancel or modify
        void DeleteBooking(int bookingId);
    }
}
