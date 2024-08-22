using BookMyMovie.Models;

namespace BookMyMovie.Services
{
    public interface ITheaterService
    {
        IEnumerable<Theater> GetAllTheaters();
        Theater? GetTheaterByName(string name);
        void AddTheater(TheaterDto movie);
        void UpdateTheater(TheaterDto movie);
        void DeleteTheater(int id);
    }
}
