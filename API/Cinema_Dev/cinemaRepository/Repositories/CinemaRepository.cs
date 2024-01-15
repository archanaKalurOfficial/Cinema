using cinemaRepository.Interfaces;
using cinemaRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace cinemaRepository.Repositories
{
    public class CinemaRepository : ICinemaRepository
    {
        public List<Movie> movies = new List<Movie>();
        public CinemaRepository()
        {
            movies = new List<Movie>()
            {
                new Movie(){
                            MOV_Key =1,
                            MOV_Name="12Th Fail",
                            MOV_DESC = "Manoj Kumar Sharma belongs to Chambal village where cheating in exam is a common thing.He is appearing for his 12th standard exams and eyeing a peon's job.But a strict police officer DCP Dushyant SIngh arrives during the exams ans stops the cheating process,Manoj is unable to pass the examinations and starts to ride a passenger vehicle with brother Kamlesh.They both land in trouble with goons of a politician but Dushyant Singh comes to their aid.Inspired by his honesty Manoj starts considering him an idol and wants to become like him.The following year he clears his exams and dreams of becoming and IAS but destiny has other plans where Manoj will have to scratch hard right from the word go.",
                            MOV_StarCount=4,
                            MOV_ActiveStatus=1,
                            MOV_CreatedOn = DateTime.Now,
                            MOV_ModifiedOn = DateTime.Now,
                            MOV_CreatedBy= 1,
                            MOV_ModifiedBy = 1,
                            MOV_RelaseYear = "2023",
                            MOV_MovieTimeInHour = 2,
                            MOV_MovieTimeInMinute= 30,
                            MOV_Origin = "India",
                            MOV_Type = "Emotional",
                            MOV_DirectedBy = "Vidhu Vinod Chopra",
                            MOV_Cast ="Vikrant Massey, Medha Shankar",
                            MOV_Language = "Hindi",
                            MOV_ProducedBy = "Prashant Bidkar",
                            MOV_MoviePoster= new MoviePoster(){
                                                MOV_IMG_Key = 2,
                                                MOV_IMG_Name = "Movie_12thFail_img_2.jpg",
                                                MOV_IMG_LocalPath="/Movie_12thFail_img_2.jpg",
                                                MOV_ActiveStatus = 1,
                                                MOV_IMG_CreatedOn = DateTime.Now,
                                                MOV_IMG_ModifiedOn= DateTime.Now,
                                                MOV_IMG_CreatedBy = 1,
                                                MOV_IMG_ModifiedBy = 1,
                                                },
                            MOV_MovieImg = new MoviePoster(){
                                                MOV_IMG_Key = 1,
                                                MOV_IMG_Name = "Movie_12thFail_img.jpg",
                                                MOV_IMG_LocalPath="/Movie_12thFail_img.jpg",
                                                MOV_ActiveStatus = 1,
                                                MOV_IMG_CreatedOn = DateTime.Now,
                                                MOV_IMG_ModifiedOn= DateTime.Now,
                                                MOV_IMG_CreatedBy = 1,
                                                MOV_IMG_ModifiedBy = 1,
                                                },
                            MOV_IsFav =1
                            },
                new Movie(){MOV_Key =1,
                            MOV_Name="As Mummies",
                            MOV_DESC = "It follows three mummies as they end up in present-day London and embark on a journey in search of an old ring belonging to the Royal Family, stolen by the ambitious archaeologist Lord Carnaby.",
                            MOV_StarCount=4,
                            MOV_ActiveStatus=1,
                            MOV_CreatedOn = DateTime.Now,
                            MOV_ModifiedOn = DateTime.Now,
                            MOV_CreatedBy= 1,
                            MOV_ModifiedBy = null,
                            MOV_RelaseYear = "2022",
                            MOV_MovieTimeInHour = 2,
                            MOV_MovieTimeInMinute= 30,
                            MOV_Origin = "London",
                            MOV_Type = "Comedy",
                            MOV_DirectedBy = "Juan Jesús García Galocha",
                            MOV_Cast ="Óscar Barberán, Ana Esther AlborgLuis Reina",
                            MOV_Language = "Hindi",
                            MOV_ProducedBy = "Jordi Gasull, Lillian González",
                            MOV_MovieImg  =new MoviePoster(){
                                                                MOV_IMG_Key = 1,
                                                                MOV_IMG_Name = "As Mummies.jpg",
                                                                MOV_IMG_LocalPath="/Movie_Hi_Nanna_img.jpg",
                                                                MOV_ActiveStatus = 1,
                                                                MOV_IMG_CreatedOn = DateTime.Now,
                                                                MOV_IMG_ModifiedOn= DateTime.Now,
                                                                MOV_IMG_CreatedBy = 1,
                                                                MOV_IMG_ModifiedBy = 1,
                                                                },
                            MOV_MoviePoster= new MoviePoster(){
                                                                MOV_IMG_Key = 1,
                                                                MOV_IMG_Name = "As Mummies.jpg",
                                                                MOV_IMG_LocalPath="D:/Archana/Archana Practice Projects/Dot Net Core/Cinema_Dev/Cinema_Dev/Movie_Image/As Mummies.jpg",
                                                                MOV_ActiveStatus = 1,
                                                                MOV_IMG_CreatedOn = DateTime.Now,
                                                                MOV_IMG_ModifiedOn= null,
                                                                MOV_IMG_CreatedBy = 1,
                                                                MOV_IMG_ModifiedBy = 1,
                                                                },
                            MOV_IsFav =1
                            },
                new Movie(){MOV_Key =1,
                            MOV_Name="Salllar 2",
                            MOV_DESC = "A gang leader tries to keep a promise made to his dying friend and takes on the other criminal gangs.",
                            MOV_StarCount=5,
                            MOV_ActiveStatus=1,
                            MOV_CreatedOn = DateTime.Now,
                            MOV_ModifiedOn = null,
                            MOV_CreatedBy= 1,
                            MOV_ModifiedBy = 1,
                            MOV_RelaseYear = "2021",
                            MOV_MovieTimeInHour = 1,
                            MOV_MovieTimeInMinute= 30,
                            MOV_Origin = "Paris",
                            MOV_Type = "Action,Comedy",
                            MOV_DirectedBy = "Prashanth Neel",
                            MOV_Cast ="Prabhas, Prithviraj Sukumaran, Shruti Haasan",
                            MOV_Language = "English",
                            MOV_ProducedBy = "Chaluve Gowda, Vijay Kiragandur",
                            MOV_MovieImg = new MoviePoster(){
                                                                MOV_IMG_Key = 1,
                                                                MOV_IMG_Name = "Salaar 2.jpg",
                                                                MOV_IMG_LocalPath="D:/Archana/Archana Practice Projects/Dot Net Core/Cinema_Dev/Cinema_Dev/Movie_Image/Salaar 2.jpg",
                                                                MOV_ActiveStatus = 1,
                                                                MOV_IMG_CreatedOn = DateTime.Now,
                                                                MOV_IMG_ModifiedOn= null,
                                                                MOV_IMG_CreatedBy = 1,
                                                                MOV_IMG_ModifiedBy = 1,
                                                                },
                            MOV_IsFav =1
                            },
                new Movie(){MOV_Key =4,
                MOV_Name="Kho Gaye Hum Kahan",
                MOV_DESC = "Three best friends juggle life as 20-somethings in Mumbai, where romance, ambition and heartbreak collide with the addictive draw of social media.",
                MOV_StarCount=6,
                MOV_ActiveStatus=1,
                MOV_CreatedOn = DateTime.Now,
                MOV_ModifiedOn = DateTime.Now,
                MOV_CreatedBy= 1,
                MOV_ModifiedBy = 1,
                MOV_RelaseYear=  "2023",
                MOV_MovieTimeInHour = 2,
                MOV_MovieTimeInMinute= 20,
                MOV_Origin = "India",
                MOV_DirectedBy= "Arjun Varain Singh",
                MOV_ProducedBy= "Zoya Akhtar,Reema Kagti,Ritesh Sidhwani,Farhan Akhtar",
                MOV_Cast="Adarsh Gourav,Siddhant Chaturvedi,Ananya Panday,Kalki Koechlin,Anya Singh",
                MOV_Language = "Hindi",
                MOV_Type = "Romance/Comedy",
                MOV_MovieImg = new MoviePoster(){
                                                    MOV_IMG_Key = 1,
                                                    MOV_IMG_Name = "Movie_Kho_Gaye_Hum_Kahan_img.jpg",
                                                    MOV_IMG_LocalPath="/Movie_Kho_Gaye_Hum_Kahan_img.jpg",
                                                    MOV_ActiveStatus = 1,
                                                    MOV_IMG_CreatedOn = DateTime.Now,
                                                    MOV_IMG_ModifiedOn= DateTime.Now,
                                                    MOV_IMG_CreatedBy = 1,
                                                    MOV_IMG_ModifiedBy = 1,
                                                    },
                MOV_MoviePoster = new MoviePoster(){
                                                    MOV_IMG_Key = 2,
                                                    MOV_IMG_Name = "Movie_Kho_Gaye_Hum_Kahan_img_2.jpg",
                                                    MOV_IMG_LocalPath="/Movie_Kho_Gaye_Hum_Kahan_img_2.jpg",
                                                    MOV_ActiveStatus = 1,
                                                    MOV_IMG_CreatedOn = DateTime.Now,
                                                    MOV_IMG_ModifiedOn= DateTime.Now,
                                                    MOV_IMG_CreatedBy = 1,
                                                    MOV_IMG_ModifiedBy = 1,
                                                    },
                MOV_IsFav =1
                },
                new Movie(){MOV_Key =5,
                        MOV_Name="Kadak Singh",
                        MOV_DESC = "An officer of the Department of Financial Crimes is trying to solve a chit-fund scam case after being diagnosed with retrograde amnesia. He relies on listening to different perspectives on who he actually is and how he landed up in the hospital where he is being treated",
                        MOV_StarCount=6,
                        MOV_ActiveStatus=1,
                        MOV_CreatedOn = DateTime.Now,
                        MOV_ModifiedOn = DateTime.Now,
                        MOV_CreatedBy= 1,
                        MOV_ModifiedBy = 1,
                        MOV_RelaseYear="2023",
                        MOV_MovieTimeInHour = 2,
                        MOV_MovieTimeInMinute= 28,
                        MOV_Origin = "India",
                        MOV_DirectedBy= "Arjun Varain Singh",
                        MOV_ProducedBy= "Mahesh Ramanathan,Viraf Sarkari,Andre Timmins,Sabbas Joseph",
                        MOV_Cast="Pankaj Tripathi,Parvathy Thiruvothu,Sanjana Sanghi,Jaya Ahsan,Dilip Shankar,Jogi Mallang",
                        MOV_Language = "Hindi",
                        MOV_Type = "Thriller",
                        MOV_MovieImg = new MoviePoster(){
                                                            MOV_IMG_Key = 1,
                                                            MOV_IMG_Name = "Movie_Kadak_Singh_img.jpg",
                                                            MOV_IMG_LocalPath="/Movie_Kadak_Singh_img.jpg",
                                                            MOV_ActiveStatus = 1,
                                                            MOV_IMG_CreatedOn = DateTime.Now,
                                                            MOV_IMG_ModifiedOn= DateTime.Now,
                                                            MOV_IMG_CreatedBy = 1,
                                                            MOV_IMG_ModifiedBy = 1,
                                                            },
                        MOV_MoviePoster = new MoviePoster(){
                                                            MOV_IMG_Key = 2,
                                                            MOV_IMG_Name = "Movie_Kadak_Singh_img_2.jpg",
                                                            MOV_IMG_LocalPath="/Movie_Kadak_Singh_img_2.jpg",
                                                            MOV_ActiveStatus = 1,
                                                            MOV_IMG_CreatedOn = DateTime.Now,
                                                            MOV_IMG_ModifiedOn= DateTime.Now,
                                                            MOV_IMG_CreatedBy = 1,
                                                            MOV_IMG_ModifiedBy = 1,
                                                            },
                        MOV_IsFav =0

                },
                new Movie(){MOV_Key =6,
                    MOV_Name="Khufiya",
                    MOV_DESC = "An operative of the Indian spy agency known as R&AW is assigned to track down a mole who is selling defense secrets while grappling with her dual identity as a spy and a lover.",
                    MOV_StarCount=4,
                    MOV_ActiveStatus=1,
                    MOV_CreatedOn = DateTime.Now,
                    MOV_ModifiedOn = DateTime.Now,
                    MOV_CreatedBy= 1,
                    MOV_ModifiedBy = 1,
                    MOV_RelaseYear= "2023",
                    MOV_MovieTimeInHour = 2,
                    MOV_MovieTimeInMinute=57,
                    MOV_Origin = "India",
                    MOV_DirectedBy= "Vishal Bhardwaj",
                    MOV_ProducedBy= "Vishal Bhardwaj,Rekha Bhardwaj",
                    MOV_Cast="Tabu,Ali Fazal,Wamiqa Gabbi,Azmeri Haque Badhon",
                    MOV_Language = "Hindi",
                    MOV_Type = "spy thriller film",
                    MOV_MovieImg = new MoviePoster(){
                                                        MOV_IMG_Key = 1,
                                                        MOV_IMG_Name = "Movie_Khufiya_img.jpg",
                                                        MOV_IMG_LocalPath="/Movie_Khufiya_img.jpg",
                                                        MOV_ActiveStatus = 1,
                                                        MOV_IMG_CreatedOn = DateTime.Now,
                                                        MOV_IMG_ModifiedOn= DateTime.Now,
                                                        MOV_IMG_CreatedBy = 1,
                                                        MOV_IMG_ModifiedBy = 1,
                                                        },
                    MOV_MoviePoster = new MoviePoster(){
                                                        MOV_IMG_Key = 2,
                                                        MOV_IMG_Name = "Movie_Khufiya_img_2.jpg",
                                                        MOV_IMG_LocalPath="/Movie_Khufiya_img_2.jpg",
                                                        MOV_ActiveStatus = 1,
                                                        MOV_IMG_CreatedOn = DateTime.Now,
                                                        MOV_IMG_ModifiedOn= DateTime.Now,
                                                        MOV_IMG_CreatedBy = 1,
                                                        MOV_IMG_ModifiedBy = 1,
                                                        },
                    MOV_IsFav =0
                    },
                new Movie(){MOV_Key =7,
                            MOV_Name="Hi Nanna",
                            MOV_DESC = "A doting father and his 6-year-old daughter find their lives taking a dramatic turn when the woman he loves marries someone else.",
                            MOV_StarCount=3,
                            MOV_ActiveStatus=1,
                            MOV_CreatedOn = DateTime.Now,
                            MOV_ModifiedOn = DateTime.Now,
                            MOV_CreatedBy= 1,
                            MOV_ModifiedBy = 1,
                            MOV_RelaseYear= "2023",
                            MOV_MovieTimeInHour = 2,
                            MOV_MovieTimeInMinute= 55,
                            MOV_Origin = "India",
                            MOV_DirectedBy= "Shouryuv",
                            MOV_ProducedBy= "Mohan Cherukuri (CVM),Dr. Vijender Reddy,Teegala,Murthy K. S.",
                            MOV_Cast="Nan,Mrunal Thakur",
                            MOV_Language = "Telugu",
                            MOV_Type = " Romantic Drama",
                            MOV_MovieImg  =new MoviePoster(){
                                                                MOV_IMG_Key = 1,
                                                                MOV_IMG_Name = "Movie_Hi_Nanna_img.jpg",
                                                                MOV_IMG_LocalPath="/Movie_Hi_Nanna_img.jpg",
                                                                MOV_ActiveStatus = 1,
                                                                MOV_IMG_CreatedOn = DateTime.Now,
                                                                MOV_IMG_ModifiedOn= DateTime.Now,
                                                                MOV_IMG_CreatedBy = 1,
                                                                MOV_IMG_ModifiedBy = 1,
                                                                },
                            MOV_MoviePoster = new MoviePoster(){
                                                                MOV_IMG_Key = 2,
                                                                MOV_IMG_Name = "Movie_Hi_Nanna_img_2.jpg",
                                                                MOV_IMG_LocalPath="/Movie_Hi_Nanna_img_2.jpg",
                                                                MOV_ActiveStatus = 1,
                                                                MOV_IMG_CreatedOn = DateTime.Now,
                                                                MOV_IMG_ModifiedOn= DateTime.Now,
                                                                MOV_IMG_CreatedBy = 1,
                                                                MOV_IMG_ModifiedBy = 1,
                                                                },
                            MOV_IsFav =0
                },
                new Movie(){MOV_Key =8,
                            MOV_Name="Tiger 3",
                            MOV_DESC = "After a foe with a vendetta comes up with a sinister plan, Tiger embarks on a mission to protect his family and clear his name.",
                            MOV_StarCount=3,
                            MOV_ActiveStatus=1,
                            MOV_CreatedOn = DateTime.Now,
                            MOV_ModifiedOn = DateTime.Now,
                            MOV_CreatedBy= 1,
                            MOV_ModifiedBy = 1,
                            MOV_RelaseYear= "2023",
                            MOV_MovieTimeInHour = 2,
                            MOV_MovieTimeInMinute= 50,
                            MOV_Origin = "India",
                            MOV_DirectedBy= "Maneesh Sharma",
                            MOV_ProducedBy= "Aditya Chopra",
                            MOV_Cast="Salman Khan,Katrina Kaif,Emraan Hashmi",
                            MOV_Language = "Hindi",
                            MOV_Type = " Action,Thriller",
                            MOV_MovieImg = new MoviePoster(){
                                                                MOV_IMG_Key = 1,
                                                                MOV_IMG_Name = "Movie_Tiger3_img.jpg",
                                                                MOV_IMG_LocalPath="/Movie_Tiger3_img.jpg",
                                                                MOV_ActiveStatus = 1,
                                                                MOV_IMG_CreatedOn = DateTime.Now,
                                                                MOV_IMG_ModifiedOn= DateTime.Now,
                                                                MOV_IMG_CreatedBy = 1,
                                                                MOV_IMG_ModifiedBy = 1,
                                                                },
                            MOV_MoviePoster = new MoviePoster(){
                                                                MOV_IMG_Key = 2,
                                                                MOV_IMG_Name = "Movie_Tiger3_img_2.jpg",
                                                                MOV_IMG_LocalPath="/Movie_Tiger3_img_2.jpg",
                                                                MOV_ActiveStatus = 1,
                                                                MOV_IMG_CreatedOn = DateTime.Now,
                                                                MOV_IMG_ModifiedOn= DateTime.Now,
                                                                MOV_IMG_CreatedBy = 1,
                                                                MOV_IMG_ModifiedBy = 1,
                                                                },
                            MOV_IsFav =0
                },
                new Movie(){MOV_Key =9,
                            MOV_Name="OMG2",
                            MOV_DESC = "A devout father takes on a dogmatic school - and his own moral convictions - after his son is expelled from school for an embarrassing video that has gone viral.",
                            MOV_StarCount=3,
                            MOV_ActiveStatus=1,
                            MOV_CreatedOn = DateTime.Now,
                            MOV_ModifiedOn = DateTime.Now,
                            MOV_CreatedBy= 1,
                            MOV_ModifiedBy = 1,
                            MOV_RelaseYear= "2023",
                            MOV_MovieTimeInHour = 2,
                            MOV_MovieTimeInMinute= 55,
                            MOV_Origin = "India",
                            MOV_DirectedBy= "Amit Rai",
                            MOV_ProducedBy= "Aruna Bhatia,Vipul D. Shah,Rajesh Bahl,Ashwin Varde",
                            MOV_Cast="Akshay Kumar,Pankaj Tripathi,Yami Gautam Dhar",
                            MOV_Language = "Hindi",
                            MOV_Type = "Comedy/Drama",
                            MOV_MovieImg = new MoviePoster(){
                                                                MOV_IMG_Key = 1,
                                                                MOV_IMG_Name = "Movie_OMG2_img.jpg",
                                                                MOV_IMG_LocalPath="/Movie_OMG2_img.jpg",
                                                                MOV_ActiveStatus = 1,
                                                                MOV_IMG_CreatedOn = DateTime.Now,
                                                                MOV_IMG_ModifiedOn= DateTime.Now,
                                                                MOV_IMG_CreatedBy = 1,
                                                                MOV_IMG_ModifiedBy = 1,
                                                                },
                            MOV_MoviePoster = new MoviePoster(){
                                                                MOV_IMG_Key = 2,
                                                                MOV_IMG_Name = "Movie_OMG2_img_2.jpg",
                                                                MOV_IMG_LocalPath="/Movie_OMG2_img_2.jpg",
                                                                MOV_ActiveStatus = 1,
                                                                MOV_IMG_CreatedOn = DateTime.Now,
                                                                MOV_IMG_ModifiedOn= DateTime.Now,
                                                                MOV_IMG_CreatedBy = 1,
                                                                MOV_IMG_ModifiedBy = 1,
                                                                },
                            MOV_IsFav =0
                },
                new Movie(){MOV_Key = 10,
                            MOV_Name="Pathaan",
                            MOV_DESC = "A Pakistani general hires a private terror outfit to conduct attacks in India while Pathaan, an Indian secret agent, is on a mission to form a special unit.",
                            MOV_StarCount=3,
                            MOV_ActiveStatus=1,
                            MOV_CreatedOn = DateTime.Now,
                            MOV_ModifiedOn = DateTime.Now,
                            MOV_CreatedBy= 1,
                            MOV_ModifiedBy = 1,
                            MOV_RelaseYear= "2023",
                            MOV_MovieTimeInHour = 2,
                            MOV_MovieTimeInMinute= 46,
                            MOV_Origin = "India",
                            MOV_DirectedBy= "Siddharth Anand",
                            MOV_ProducedBy= "Aditya Chopra",
                            MOV_Cast="Shah Rukh Khan,Deepika Padukone,John Abraham,Dimple Kapadia,Ashutosh Rana",
                            MOV_Language = "Hindi",
                            MOV_Type = "Action/Thriller",
                            MOV_MovieImg = new MoviePoster(){
                                                                MOV_IMG_Key = 1,
                                                                MOV_IMG_Name = "Movie_Pathaan_img.jpg",
                                                                MOV_IMG_LocalPath="/Movie_Pathaan_img.jpg",
                                                                MOV_ActiveStatus = 1,
                                                                MOV_IMG_CreatedOn = DateTime.Now,
                                                                MOV_IMG_ModifiedOn= DateTime.Now,
                                                                MOV_IMG_CreatedBy = 1,
                                                                MOV_IMG_ModifiedBy = 1,
                                                                },
                            MOV_MoviePoster = new MoviePoster(){
                                                                MOV_IMG_Key = 2,
                                                                MOV_IMG_Name = "Movie_Pathaan_img_2.jpg",
                                                                MOV_IMG_LocalPath="/Movie_Pathaan_img_2.jpg",
                                                                MOV_ActiveStatus = 1,
                                                                MOV_IMG_CreatedOn = DateTime.Now,
                                                                MOV_IMG_ModifiedOn= DateTime.Now,
                                                                MOV_IMG_CreatedBy = 1,
                                                                MOV_IMG_ModifiedBy = 1,
                                                                },
                            MOV_IsFav =0
                }
            };

        }
        public Dashboard FetchDashboardData(int intUser_Id)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.FeaturedMovies = movies;
            dashboard.RecentWatchedMovies = dashboard.FavMovies = movies;
            dashboard.RecentlyAddedMovies = movies.FindAll(m => m.MOV_Key <= 10);
            return dashboard;
        }
        public List<Movie> FetchFavMovieList(int intUser_Id)
        {
            List<Movie> lstFavMovies  = new List<Movie>();
            lstFavMovies = movies.FindAll(m => m.MOV_IsFav == 1);
            return lstFavMovies;
        }
        public Movie FetchMovieDetail(int intMOV_Key)
        {
            Movie objMovie = new Movie();
            objMovie = movies.FirstOrDefault(m => m.MOV_Key == intMOV_Key);
            return objMovie;
        }
        public List<Movie> FetchUserPreferences(int intUser_Id)
        {
            List<Movie> lstmovies = new List<Movie>();
            lstmovies = movies;
            return lstmovies;
        }
        public List<Movie> FetchSearchedMovieList(string strMOV_Name)
        {
            List<Movie> lstSearchedMovies = new List<Movie>();
            lstSearchedMovies = movies.FindAll(m => m.MOV_Name.ToUpper().Contains(strMOV_Name.ToUpper().Trim()));
            return lstSearchedMovies;
        }
        public Movie ManageFavMovie(UserFavMovies objUserFavMovies)
        {
            int intRrtVal = 0;
            try
            {
                Movie objMovie = movies.Find(m => m.MOV_Key == objUserFavMovies.UFM_MOV_Key);
                if (objMovie != null)
                {
                    objMovie.MOV_IsFav = 1;
                }
                return objMovie;
            }
            catch (Exception ex)
            {
                return null;
            }
            
        }
    }
}
