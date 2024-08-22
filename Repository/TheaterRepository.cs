using BookMyMovie.DB;
using BookMyMovie.Models;

namespace BookMyMovie.Repository
{
    public class TheaterRepository : ITheaterRepository
    {
        private readonly MovieDBContext _context;

        public TheaterRepository(MovieDBContext context)
        {
            _context = context;
        }

        public void AddTheater(TheaterDto Theater)
        {
            try
            {
                var request = new Theater()
                {
                    Name = Theater.Name,
                    Location = Theater.Location
                };
                _context.Theaters.Add(request);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void DeleteTheater(int id)
        {
            var result = _context.Theaters.Find(id);

            if (result != null)
            {
                _context.Theaters.Remove(result);
                _context.SaveChanges();
            }
        }

        public IEnumerable<Theater> GetAllTheaters()
        {
            try
            {
                IEnumerable<Theater> Theaters = _context.Theaters.ToList();
                return Theaters;
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
                var result = _context.Theaters.Where(m => m.Name == name).FirstOrDefault();
                return result;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public void UpdateTheater(TheaterDto theater)
        {
            try
            {
                var theaterInDb = _context.Theaters.Where(m => m.Name == theater.Name).SingleOrDefault();

                if (theaterInDb != null)
                {
                    theaterInDb.Name = theater.Name;
                    theaterInDb.Location = theater.Location;

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
