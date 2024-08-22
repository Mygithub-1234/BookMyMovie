using BookMyMovie.DB;
using BookMyMovie.Models;
using System.Text.Json;
using System.Text;
using Azure.Messaging.ServiceBus;
using Newtonsoft.Json;

namespace BookMyMovie.Repository
{
    public class BookingRepository : IBookingRepository
    {
        private readonly MovieDBContext _context;
        private readonly string _connectionString;
        private readonly string _queueName;

        public BookingRepository(MovieDBContext context, IConfiguration configuration)
        {
            _context = context;
            _connectionString = configuration.GetSection("ServiceBus:ConnectionString").Value;
            _queueName = configuration.GetSection("ServiceBus:QueueName").Value;
        }
        public async Task CreateBookingAndSendEvent(BookingDto booking)
        {
            try
            {
                var request = new Booking()
                {
                    BookingDate = booking.BookingDate,
                    NumberOfTickets = booking.NumberOfTickets,
                    TotalPrice = booking.TotalPrice,
                    BookingStatus = BookingStatus.Pending,
                    PaymentStatus = PaymentStatus.Pending
                };
                _context.Bookings.Add(request);
                _context.SaveChanges();

                await using var client = new ServiceBusClient(_connectionString);
                var sender = client.CreateSender(_queueName);

                var messageBody = JsonConvert.SerializeObject(request);
                var message = new ServiceBusMessage(Encoding.UTF8.GetBytes(messageBody));

                // Send the message
                await sender.SendMessageAsync(message);
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
