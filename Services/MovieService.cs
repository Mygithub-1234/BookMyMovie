using BookMyMovie.Models;
using BookMyMovie.Repository;


namespace BookMyMovie.Services
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _movieRepository;

        public MovieService(IMovieRepository movieRepository)

        {
            _movieRepository = movieRepository;
        }

        public void AddMovie(MovieDto movie)
        {
            try
            {
                _movieRepository.AddMovie(movie);

            }
            catch (Exception)
            {

                throw;
            }
        }

        public void DeleteMovie(int id)
        {
            try
            {
                _movieRepository.DeleteMovie(id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IEnumerable<Movie> GetAllMovies()
        {
            try
            {
                var result = _movieRepository.GetAllMovies();
                return result;
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
                var result = _movieRepository.GetMovieByName(name);
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
                _movieRepository.UpdateMovie(movie);
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
