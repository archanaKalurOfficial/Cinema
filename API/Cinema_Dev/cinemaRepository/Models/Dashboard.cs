using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cinemaRepository.Models
{
    public class Dashboard
    {
        private List<Movie> lstRecentlyAddedMovies;
        public List<Movie> RecentlyAddedMovies
        {
            get { return lstRecentlyAddedMovies; }
            set { lstRecentlyAddedMovies = value; }
        }

        private List<Movie> lstRecentWatchedMovies;
        public List<Movie> RecentWatchedMovies
        {
            get { return lstRecentWatchedMovies; }
            set { lstRecentWatchedMovies = value; }
        }

        private List<Movie> lstFavMovies;
        public List<Movie> FavMovies
        {
            get { return lstFavMovies; }
            set { lstFavMovies = value; }
        }

        private List<Movie> lstFeaturedMovies;

        public List<Movie> FeaturedMovies 
        {
            get { return lstFeaturedMovies; }
            set { lstFeaturedMovies = value; }
        }




    }
}
