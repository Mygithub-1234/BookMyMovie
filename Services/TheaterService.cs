using BookMyMovie.Models;
using BookMyMovie.Repository;

namespace BookMyMovie.Services
{
    public class TheaterService : ITheaterService
    {
        private readonly ITheaterRepository _theaterRepository;

        public TheaterService(ITheaterRepository theaterRepository)
        {
            _theaterRepository = theaterRepository;
        }

        public void AddTheater(TheaterDto Theater)
        {
            try
            {
                _theaterRepository.AddTheater(Theater);

            }
            catch (Exception)
            {

                throw;
            }
        }


        public void DeleteTheater(int id)
        {
            try
            {
                _theaterRepository.DeleteTheater(id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IEnumerable<Theater> GetAllTheaters()
        {
            try
            {
                var result = _theaterRepository.GetAllTheaters();
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Theater? GetTheaterByName(string name)
        {
            try
            {
                var result = _theaterRepository.GetTheaterByName(name);
                return result;

            }
            catch (Exception)
            {

                throw;
            }

        }

        public void UpdateTheater(TheaterDto Theater)
        {
            try
            {
                _theaterRepository.UpdateTheater(Theater);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
