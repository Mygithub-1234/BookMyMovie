using BookMyMovie.Models;

namespace BookMyMovie.Repository
{
    public interface IMovieRepository
    {
        IEnumerable<Movie> GetAllMovies();
        Movie? GetMovieByName(string name);
        void AddMovie(MovieDto movie);
        void UpdateMovie(MovieDto movie);
        void DeleteMovie(int id);
    }
}
