using BookMyMovie.Models;
using BookMyMovie.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BookMyMovie.Services
{
    public class BookingService : IBookingService
    {
        private readonly IEventBus _eventBus;
        private readonly IBookingRepository _bookingRepository;

        public BookingService(IBookingRepository bookingRepository, IEventBus eventBus)

        {
            _bookingRepository = bookingRepository;
            _eventBus = eventBus;
        }
        public void CreateBooking(BookingDto booking)
        {
            try
            {
                var result = _bookingRepository.CreateBookingAndSendEvent(booking);
                _eventBus.Publish(result);

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
