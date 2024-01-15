using cinemaRepository.Interfaces;
using cinemaRepository.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cinema_Dev.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CinemaController : ControllerBase
    {
        private readonly ICinemaRepository cinemaRepository;
        public CinemaController(ICinemaRepository _cinemaRepository)
        {
            this.cinemaRepository = _cinemaRepository;
        }

        [HttpGet("fetchDashboardData")]
        public ActionResult FetchDashboardData(int intUser_Id)
        {
            try
            {
                Dashboard objDashboard = cinemaRepository.FetchDashboardData(intUser_Id);

                if (objDashboard == null)
                {
                    return BadRequest(new { data = "Data not Found!" });
                }

                return Ok(new { data = objDashboard });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("fetchMovieDetail")]
        public ActionResult FetchMovieDetail(int intMOV_Key)
        {
            try
            {
                Movie objMovieDetail = cinemaRepository.FetchMovieDetail(intMOV_Key);

                if (objMovieDetail == null)
                {
                    return BadRequest(new { data = "Data not Found!" });
                }

                return Ok(new { data = objMovieDetail });

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("manageFavMovie")]
        public ActionResult ManageFavMovie(UserFavMovies objUserFavMovies)
        {
            try
            {
                Movie objMovie = null;
                objMovie = cinemaRepository.ManageFavMovie(objUserFavMovies);

                if (objMovie == null)
                {
                    return BadRequest(new { data = "Error Found!" });
                }

                return Ok(new { data = objMovie });

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("fetchUserPreferences")]
        public ActionResult FetchUserPreferences(int intUser_Id)
        {
            try
            {
                List<Movie> lstMovies = null;
                lstMovies = cinemaRepository.FetchUserPreferences(intUser_Id);

                if (lstMovies == null || lstMovies.Count <= 0)
                {
                    return BadRequest(new { data = "Error Found!" });
                }
                return Ok(new { data = lstMovies });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("fetchFavMovieList")]
        public ActionResult FetchFavMovieList(int intUser_Id)
        {
            try
            {
                List<Movie> lstFavMovies = null;
                lstFavMovies = cinemaRepository.FetchFavMovieList(intUser_Id);

                if (lstFavMovies == null || lstFavMovies.Count <= 0)
                {
                    return BadRequest(new { data = "Error Found!" });
                }
                return Ok(new { data = lstFavMovies });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("fetchSearchedMovieList")]
        public ActionResult FetchSearchedMovieList(string strMOV_Name)
        {
            try
            {
                List<Movie> lstSearchedMovies = null;
                lstSearchedMovies = cinemaRepository.FetchSearchedMovieList(strMOV_Name);

                if (lstSearchedMovies == null || lstSearchedMovies.Count <= 0)
                {
                    return BadRequest(new { data = "No Data Found!" });
                }
                return Ok(new { data = lstSearchedMovies });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
