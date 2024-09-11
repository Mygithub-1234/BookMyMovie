using BookMyMovie.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookMyMovie.Repository
{
    public class MovieRepository : IMovieRepository
    {
        private readonly MovieReserveContext _context;

        public MovieRepository(MovieReserveContext context)
        {
            _context = context;
        }

        public void AddMovie(MovieDto movie)
        {
            try
            {
                var request = new Movie()
                {
                    Title = movie.Title,
                    Description = movie.Description,
                    Director = movie.Director
                };
                _context.Movies.Add(request);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void DeleteMovie(int id)
        {
            var result = _context.Movies.Find(id);

            if (result != null)
            {
                _context.Movies.Remove(result);
                _context.SaveChanges();
            }
        }

        public IEnumerable<Movie> GetAllMovies()
        {
            try
            {
                IEnumerable<Movie> movies = _context.Movies.ToList();
                return movies;
            }
            catch (Exception)
            {
                throw;
            }

        }

        public Movie? GetMovieByName(string name)
        {
            try
            {
                var result = _context.Movies.Where(m => m.Title == name).FirstOrDefault();
                return result;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public void UpdateMovie(MovieDto movie)
        {
            try
            {
                var movieInDb = _context.Movies.Where(m=>m.Title == movie.Title).SingleOrDefault();

                if (movieInDb != null)
                {
                    movieInDb.Director = movie.Director;
                    movieInDb.Title = movie.Title;
                    movieInDb.Description = movie.Description;

                    _context.SaveChanges();
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
