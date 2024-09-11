using BookMyMovie.Models;
using BookMyMovie.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BookMyMovie.Controllers
{
    [Route("api/v1.0/[controller]/")]
    [ApiController]
    //[Authorize]
    public class MovieController : ControllerBase
    {
        private readonly IMovieService _movieService;

        public MovieController(IMovieService movieService)
        {
            _movieService = movieService;
        }
        /// <summary>
        /// Get all Movies
        /// </summary>
        /// <returns></returns>
        [HttpGet("all")]

        public IActionResult GetMovies()
        {
            try
            {
                var movies = _movieService.GetAllMovies();
                return Ok(movies);
            }
            catch (Exception)
            {
                throw;
            }
        }
        /// <summary>
        /// Adds new movie
        /// </summary>
        /// <param name="movie"></param>
        /// <returns></returns>

        [HttpPost("addmovie")]
        public IActionResult Create(MovieDto movie)
        {
            try
            {
                 _movieService.AddMovie(movie);
                return Ok();
            }
            catch (Exception)
            {
                throw;
            }
        }
        /// <summary>
        /// Gets movie by name
        /// </summary>
        /// <param name="moviename"></param>
        /// <returns></returns>
        [HttpGet("search/moviename")]
        public IActionResult GetMoviebyName(string moviename)
        {
            try
            {
                var movies = _movieService.GetMovieByName(moviename);
                return Ok(movies);
            }
            catch (Exception)
            {
                throw;
            }
        }
        /// <summary>
        /// Updates a movie detail
        /// </summary>
        /// <param name="movie"></param>
        /// <returns></returns>
        [HttpPut("UpdateMovie")]
        public IActionResult Edit(MovieDto movie)
        {
            try
            {
                _movieService.UpdateMovie(movie);
                return Ok();
            }
            catch (Exception)
            {
                throw;
            }
        }
        /// <summary>
        /// Deletes a movie
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("delete/moviedelrequest")]
        public ActionResult Delete(int id)
        {
            try
            {
                _movieService.DeleteMovie(id);
                return Ok();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
