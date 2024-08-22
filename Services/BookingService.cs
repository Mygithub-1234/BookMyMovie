using BookMyMovie.Models;
using BookMyMovie.Repository;

namespace BookMyMovie.Services
{
    public class BookingService : IBookingService
    {
        private readonly IBookingRepository _bookingRepository;

        public BookingService(IBookingRepository bookingRepository)

        {
            _bookingRepository = bookingRepository;
        }
        public void CreateBooking(BookingDto booking)
        {
            try
            {
                _bookingRepository.CreateBookingAndSendEvent(booking);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void DeleteBooking(int bookingId)
        {
            try
            {
                _bookingRepository.DeleteBooking(bookingId);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Booking? GetByBookingId(int bookingId)
        {
            try
            {
                var result= _bookingRepository.GetByBookingId(bookingId);
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IEnumerable<Booking> GetByUserId(int userId)
        {
            try
            {
                var result = _bookingRepository.GetByUserId(userId);
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void UpdateBooking(int bookingId)
        {
            try
            {
                _bookingRepository.UpdateBooking(bookingId);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
