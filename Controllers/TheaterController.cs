using BookMyMovie.Models;
using BookMyMovie.Services;
using Microsoft.AspNetCore.Mvc;

namespace BookMyMovie.Controllers
{
    [Route("api/v1.0/[controller]/")]
    [ApiController]
    public class TheaterController : Controller
    {
        private readonly ITheaterService _theaterService;

        public TheaterController(ITheaterService TheaterService)
        {
            _theaterService = TheaterService;
        }
        /// <summary>
        /// Get all Theaters
        /// </summary>
        /// <returns></returns>
        [HttpGet("all")]
        public IActionResult GetTheaters()
        {
            try
            {
                var Theaters = _theaterService.GetAllTheaters();
                return Ok(Theaters);
            }
            catch (Exception)
            {
                throw;
            }
        }
        /// <summary>
        /// Adds new Theater
        /// </summary>
        /// <param name="Theater"></param>
        /// <returns></returns>

        [HttpPost("addTheater")]
        public IActionResult Create(TheaterDto Theater)
        {
            try
            {
                _theaterService.AddTheater(Theater);
                return Ok();
            }
            catch (Exception)
            {
                throw;
            }
        }
        /// <summary>
        /// Gets Theater by name
        /// </summary>
        /// <param name="Theatername"></param>
        /// <returns></returns>
        [HttpGet("search/Theatername")]
        public IActionResult GetTheaterbyName(string Theatername)
        {
            try
            {
                var Theaters = _theaterService.GetTheaterByName(Theatername);
                return Ok(Theaters);
            }
            catch (Exception)
            {
                throw;
            }
        }
        /// <summary>
        /// Updates a Theater detail
        /// </summary>
        /// <param name="Theater"></param>
        /// <returns></returns>
        [HttpPut("UpdateTheater")]
        public IActionResult Edit(TheaterDto Theater)
        {
            try
            {
                _theaterService.UpdateTheater(Theater);
                return Ok();
            }
            catch (Exception)
            {
                throw;
            }
        }
        /// <summary>
        /// Deletes a Theater
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("delete/Theaterdelrequest")]
        public ActionResult Delete(int id)
        {
            try
            {
                _theaterService.DeleteTheater(id);
                return Ok();
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
