using BookMyMovie.Models;
using System.Text.Json;
using System.Text;
using Azure.Messaging.ServiceBus;
using Newtonsoft.Json;
using BookMyMovie.Services;

namespace BookMyMovie.Repository
{
    public class BookingRepository : IBookingRepository
    {
        private readonly MovieReserveContext _context;
        private readonly string _connectionString;
        private readonly string _queueName;
        private readonly IEventBus _eventBus;

        public BookingRepository(MovieReserveContext context)
        {
            _context = context;
          
        }
        public Booking? CreateBookingAndSendEvent(BookingDto booking)
        {
            try
            {
                var BookingRequest = new Booking()
                {
                    BookingDate = booking.BookingDate,
                    NumberOfTickets = booking.NumberOfTickets,
                    TotalPrice = booking.TotalPrice,
                    BookingStatus = (int)BookingStatus.Pending,
                    PaymentStatus = (int)PaymentStatus.Pending
                };
                _context.Bookings.Add(BookingRequest);
                _context.SaveChanges();
                return BookingRequest;

               // _eventBus.Publish(BookingRequest);
            }

            catch (Exception)
            {

                throw;
            }
        }

        public void DeleteBooking(int bookingId)
        {
            throw new NotImplementedException();
        }

        public Booking? GetByBookingId(int bookingId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Booking> GetByUserId(int userId)
        {
            throw new NotImplementedException();
        }

        public void UpdateBooking(int bookingId)
        {
            throw new NotImplementedException();
        }
    }
}
