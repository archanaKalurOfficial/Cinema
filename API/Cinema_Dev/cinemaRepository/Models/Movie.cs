using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cinemaRepository.Models
{
    public class Movie
    {
        private int intMOV_Key;
        public int MOV_Key
        {
            get { return intMOV_Key; }
            set { intMOV_Key = value; }
        }

        private string strMOV_Name;

        public string MOV_Name
        {
            get { return strMOV_Name; }
            set { strMOV_Name = value; }
        }

        private string strMOV_DESC;

        public string MOV_DESC
        {
            get { return strMOV_DESC; }
            set { strMOV_DESC = value; }
        }

        private decimal intMOV_StarCount;

        public decimal MOV_StarCount
        {
            get { return intMOV_StarCount; }
            set { intMOV_StarCount = value; }
        }

        private int intMOV_ActiveStatus;

        public int MOV_ActiveStatus
        {
            get { return intMOV_ActiveStatus; }
            set { intMOV_ActiveStatus = value; }
        }

        private DateTime dtMOV_CreatedOn;

        public DateTime MOV_CreatedOn
        {
            get { return dtMOV_CreatedOn; }
            set { dtMOV_CreatedOn = value; }
        }

        private DateTime? dtMOV_ModifiedOn;

        public DateTime? MOV_ModifiedOn
        {
            get { return dtMOV_ModifiedOn; }
            set { dtMOV_ModifiedOn = value; }
        }

        private int intMOV_CreatedBy;

        public int MOV_CreatedBy
        {
            get { return intMOV_CreatedBy; }
            set { intMOV_CreatedBy = value; }
        }

        private int? intMOV_ModifiedBy;
        public int? MOV_ModifiedBy
        {
            get { return intMOV_ModifiedBy; }
            set { intMOV_ModifiedBy = value; }
        }

        private string dtMOV_RelaseYear;
        public string MOV_RelaseYear
        {
            get { return dtMOV_RelaseYear; }
            set { dtMOV_RelaseYear = value; }
        }

        private int intMOV_MovieTimeInHour;

        public int MOV_MovieTimeInHour
        {
            get { return intMOV_MovieTimeInHour; }
            set { intMOV_MovieTimeInHour = value; }
        }

        private int intMOV_MovieTimeInMinute;

        public int MOV_MovieTimeInMinute
        {
            get { return intMOV_MovieTimeInMinute; }
            set { intMOV_MovieTimeInMinute = value; }
        }

        private string strMOV_Origin;

        public string MOV_Origin
        {
            get { return strMOV_Origin; }
            set { strMOV_Origin = value; }
        }

        private MoviePoster objMOV_MoviePoster;

        public MoviePoster MOV_MoviePoster
        {
            get { return objMOV_MoviePoster; }
            set { objMOV_MoviePoster = value; }
        }

        private MoviePoster objMOV_MovieImg;

        public MoviePoster MOV_MovieImg
        {
            get { return objMOV_MovieImg; }
            set { objMOV_MovieImg = value; }
        }

        private string strMOV_DirectedBy;
        public string MOV_DirectedBy
        {
            get { return strMOV_DirectedBy; }
            set { strMOV_DirectedBy = value; }
        }

        private string strMOV_ProducedBy;

        public string MOV_ProducedBy
        {
            get { return strMOV_ProducedBy; }
            set { strMOV_ProducedBy = value; }
        }

        private string strMOV_Cast;

        public string MOV_Cast
        {
            get { return strMOV_Cast; }
            set { strMOV_Cast = value; }
        }

        private string strMOV_Language;
        public string MOV_Language
        {
            get { return strMOV_Language; }
            set { strMOV_Language = value; }
        }
        private string strMOV_Type;

        public string MOV_Type
        {
            get { return strMOV_Type; }
            set { strMOV_Type = value; }
        }

        private int intMOV_IsFav;

        public int MOV_IsFav
        {
            get { return intMOV_IsFav; }
            set { intMOV_IsFav = value; }
        }



    }
    public class MoviePoster
    {
        private int intMOV_IMG_Key;

        public int MOV_IMG_Key
        {
            get { return intMOV_IMG_Key; }
            set { intMOV_IMG_Key = value; }
        }

        private string strMOV_IMG_Name;

        public string MOV_IMG_Name
        {
            get { return strMOV_IMG_Name; }
            set { strMOV_IMG_Name = value; }
        }

        private string strMOV_IMG_LocalPath;
        public string MOV_IMG_LocalPath
        {
            get { return strMOV_IMG_LocalPath; }
            set { strMOV_IMG_LocalPath = value; }
        }

        private int intMOV_IMG_ActiveStatus;

        public int MOV_ActiveStatus
        {
            get { return intMOV_IMG_ActiveStatus; }
            set { intMOV_IMG_ActiveStatus = value; }
        }

        private DateTime dtMOV_IMG_CreatedOn;

        public DateTime MOV_IMG_CreatedOn
        {
            get { return dtMOV_IMG_CreatedOn; }
            set { dtMOV_IMG_CreatedOn = value; }
        }

        private DateTime? dtMOV_IMG_ModifiedOn;

        public DateTime? MOV_IMG_ModifiedOn
        {
            get { return dtMOV_IMG_ModifiedOn; }
            set { dtMOV_IMG_ModifiedOn = value; }
        }

        private int intMOV_IMG_CreatedBy;

        public int MOV_IMG_CreatedBy
        {
            get { return intMOV_IMG_CreatedBy; }
            set { intMOV_IMG_CreatedBy = value; }
        }

        private int intMOV_IMG_ModifiedBy;
        public int MOV_IMG_ModifiedBy
        {
            get { return intMOV_IMG_ModifiedBy; }
            set { intMOV_IMG_ModifiedBy = value; }
        }

    }
    public class UserFavMovies
    {
        private int intUFM_Key;
        public int UFM_Key
        {
            get { return intUFM_Key; }
            set { intUFM_Key = value; }
        }

        private int intUFM_ActiveStatus;
        public int UFM_ActiveStatus
        {
            get { return intUFM_ActiveStatus; }
            set { intUFM_ActiveStatus = value; }
        }

        private DateTime dtUFM_CreatedOn;
        public DateTime UFM_CreatedOn
        {
            get { return dtUFM_CreatedOn; }
            set { dtUFM_CreatedOn = value; }
        }

        private DateTime dtUFM_ModifiedOn;
        public DateTime UFM_ModifiedOn
        {
            get { return dtUFM_ModifiedOn; }
            set { dtUFM_ModifiedOn = value; }
        }

        private int intUFM_UserKey;
        public int UFM_UserKey
        {
            get { return intUFM_UserKey; }
            set { intUFM_UserKey = value; }
        }

        private int intUFM_MOV_Key;
        public int UFM_MOV_Key
        {
            get { return intUFM_MOV_Key; }
            set { intUFM_MOV_Key = value; }
        }
    }
}
