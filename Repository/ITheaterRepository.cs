using BookMyMovie.Models;

namespace BookMyMovie.Repository
{
    public interface ITheaterRepository
    {
        IEnumerable<Theater> GetAllTheaters();
        Theater? GetTheaterByName(string name);
        void AddTheater(TheaterDto movie);
        void UpdateTheater(TheaterDto movie);
        void DeleteTheater(int id);
    }
}
