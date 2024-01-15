using cinemaRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cinemaRepository.Interfaces
{
    public interface ICinemaRepository
    {
        Dashboard FetchDashboardData(int intUser_Id);
        Movie FetchMovieDetail(int intMOV_Key);
        List<Movie> FetchUserPreferences(int intUser_Id);
        List<Movie> FetchFavMovieList(int intUser_Id);
        Movie ManageFavMovie(UserFavMovies objUserFavMovies);
        List<Movie> FetchSearchedMovieList(string strMOV_Name);
    }
}
