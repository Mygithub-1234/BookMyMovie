using BookMyMovie.Models;

namespace BookMyMovie.Services
{
    public interface IMovieService
    {
        IEnumerable<Movie> GetAllMovies();
        Movie? GetMovieByName(string name);
        void AddMovie(MovieDto movie);
        void UpdateMovie(MovieDto movie);
        void DeleteMovie(int id);
    }
}
