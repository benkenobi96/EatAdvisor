using EatAdvisor.Class_models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EatAdvisor.DB
{
    public class DataLoader
    {
        public List<User> Users { get; set; }
        public List<Rating> Ratings { get; set; }
        public List<Restaurant> Restaurants { get; set; }

        public DataLoader( ref List<User> users, ref List<Rating> ratings, ref List<Restaurant> restaurants)
        {
            this.Users = users;
            this.Ratings = ratings;
            this.Restaurants = restaurants;
        }
        public DataLoader()
        {

        }
        internal bool Registration(User u)
        {
            bool rvSucceed = false;
            Users.Add(u);
            if (WriteNewUserToTextFile(u))
            {
                rvSucceed = true;
            }
            return rvSucceed;
        }
    
        
        //Belépés
        internal User LogIn(string id, string pwd)
        {
            User retUser = null;
            foreach (User u in Users)
            {
                if (u.UserId == id && u.Pwd == pwd)
                {
                    retUser = u;
                    break;
                }
            }
            return retUser;
        }

        //username ellenőrzése regisztráciokor
        internal bool CheckUserNameUnique(string userID)
        {
            foreach (User us in Users)
            {
                if (us.UserId == userID)
                {
                    return false;

                }
            }
            return true;
        }
        internal bool CheckEmailUnique(string email)
        {
            foreach (User us in Users)
            {
                if (us.Email == email)
                {
                    return false;

                }
            }
            return true;
        }
        //---------------------------------------------------------------------------------LOGIN
        // Userek kiírása fájlba
        /*
        internal bool PrintAllUsers()
        {
            bool result = false;
            using (StreamWriter w = new StreamWriter(DBPaths.usersDataFile))
            {
                foreach (User u in Users)
                {
                    w.Write(u.UserId + ';');
                    w.Write(u.Pwd + ';');
                    w.Write(u.Name + ';');
                    w.Write(u.Email);
                    w.WriteLine();
                }
                w.Flush();
                result = true;
            }
            return result;
        }
        
        // Értékelések kiírása fájlba
        internal bool PrintAllRatings()
        {
            bool result = false;
            using (StreamWriter w = new StreamWriter(DBPaths.ratingsDataFile))
            {
                foreach (Rating r in Ratings)
                {
                    w.Write(r.UserId + ';');
                    w.Write(r.RestaurantName + ';');
                    w.Write(r.QualityOfFood + ';');
                    w.Write(r.PriceValue + ';');
                    w.Write(r.Service + ';');
                    w.Write(r.Mood + ';');
                    w.Write(r.CleanLiness);
                    
                    w.WriteLine();

                }
                w.Flush();
                result = true;
            }
            return result;
        }
        // Éttermek kiírása fájlba
        internal bool PrintAllRestaurants()
        {
            bool result = false;
            using (StreamWriter w = new StreamWriter(DBPaths.restaurantsDataFile))
            {
                foreach (Restaurant r in Restaurants)
                {
                    w.Write(r.Name + ';');
                    w.Write(r.Address );
                    w.WriteLine();

                }
                w.Flush();
                result = true;
            }
            return result;
        }
        */

        //Új értékelés mentés fileba
        internal bool WriteNewRatingToTextFile(Rating rating)
        {
            bool result = false;
            using (StreamWriter w = new StreamWriter(DBPaths.ratingsDataFile, append: true))
            {
                w.WriteLine();
                w.Write(rating.UserId + ';');
                w.Write(rating.RestaurantName + ';');
                w.Write(rating.QualityOfFood.ToString() + ';');
                w.Write(rating.PriceValue.ToString() + ';');
                w.Write(rating.Service.ToString() + ';');
                w.Write(rating.Mood.ToString() + ';');
                w.Write(rating.CleanLiness.ToString());

                w.Flush();
                result = true;
            }
            Ratings.Add(rating);
            return result;
        }
        // uj étterem mentés fileba
        internal bool WriteNewRestaurantToTextFile(Restaurant rest)
        {
            bool result = false;
            using (StreamWriter w = new StreamWriter(DBPaths.restaurantsDataFile, append: true))
            {
                w.WriteLine();
                w.Write(rest.Name + ';');
                w.Write(rest.Address);
                result = true;
            }
            Restaurants.Add(rest);
            return result;
        }

        // uj user mentés fileba
        private bool WriteNewUserToTextFile(User u)
        {
            bool result = false;
            using (StreamWriter w = new StreamWriter(DBPaths.usersDataFile, append: true))
            {
                w.WriteLine();
                w.Write(u.UserId + ';');
                w.Write(u.Pwd + ';');
                w.Write(u.Name + ';');
                w.Write(u.Email);

                w.Flush();
                result = true;
            }
            return result;
        }        //adott étteremhez tartozó  értékelések lekérése        internal List<Rating> GetRatingsByRestaurantName(string restaurantName)
        {
            List<Rating> restRatings = new List<Rating>();

            foreach (Rating r in Ratings)
            {
                if (r.RestaurantName.Equals(restaurantName))
                {
                    restRatings.Add(r);
                }
            }
            return restRatings;
        }        //éttermek nevének lekérése        internal List<String> getRestaurantNames()
        {
            List<String> names = new List<String>();
            foreach (Restaurant restaurant in Restaurants)
            {
                names.Add(restaurant.Name);
            }
            return names;
        }        //átlag kalkulálás        private double calculateAVG(List<int> data)
        {
            double avg = 0;
            int sum = 0;
            int numOfElements = data.Count();

            foreach (int element in data)
            {
                sum += element;
            }
            if (sum == 0 || numOfElements == 0)
            {
                avg = 0;
            }
            else
            {
                avg = sum / numOfElements;
            }

            return avg;
        }              //Átlagok lekérése éttermenként        public void setAverages()
        {
            foreach(Restaurant rN in Restaurants)
            {
                Dictionary<string, double> averages = new Dictionary<string, double>();

                List<int> qualityAVG = new List<int>();
                List<int> priceValueAVG = new List<int>();
                List<int> serviceAVG = new List<int>();
                List<int> moodAVG = new List<int>();
                List<int> cleanAVG = new List<int>();

                double qAVG = 0;
                double pvAVG = 0;
                double sAVG = 0;
                double mAVG = 0;
                double cAVG = 0;

                foreach (Rating r in Ratings)
                {
                    if (rN.Name.Equals(r.RestaurantName))
                    {
                        qualityAVG.Add(r.QualityOfFood);
                        priceValueAVG.Add(r.PriceValue);
                        serviceAVG.Add(r.Service);
                        moodAVG.Add(r.Mood);
                        cleanAVG.Add(r.CleanLiness);
                    }
                }
             
                qAVG = calculateAVG(qualityAVG);
                pvAVG = calculateAVG(priceValueAVG);
                sAVG = calculateAVG(serviceAVG);
                mAVG = calculateAVG(moodAVG);
                cAVG = calculateAVG(cleanAVG);

                averages.Add("Quality",qAVG);
                averages.Add("PriceValue",pvAVG);
                averages.Add("Service",sAVG);
                averages.Add("Mood",mAVG);
                averages.Add("Clean",cAVG);

                rN.Averages = averages;

            }

        }        public Restaurant selectRestaurant(string name)
        {
            foreach (Restaurant rest in Restaurants)
            {
                if (name.Equals(rest.Name))
                {
                    return rest;
                }
            }
            return null;
        }
    }
}
