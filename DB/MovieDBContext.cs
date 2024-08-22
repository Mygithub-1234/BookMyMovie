using BookMyMovie.Models;
using Microsoft.EntityFrameworkCore;

namespace BookMyMovie.DB
{
    public class MovieDBContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public MovieDBContext(DbContextOptions<MovieDBContext> options, IConfiguration configuration)
            : base(options)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_configuration.GetConnectionString("DefaultConnection"));

            }
        }

        // Your DbSet properties
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Screen> Screens { get; set; }
        public DbSet<Theater> Theaters { get; set; }
        public DbSet<Db_User> Db_Users { get; set; }

        public DbSet<Booking> Bookings { get; set; }

    }

}

