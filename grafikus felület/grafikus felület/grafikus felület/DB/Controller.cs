using EatAdvisor.Class_models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EatAdvisor.DB
{
    public class Controller
    {
        private DataLoader data;
        public User User { get; set; }
        public Restaurant Restaurant{ get; set; }

        public Controller(ref List<User> users, ref List<Rating> ratings, ref List<Restaurant> restaurants)
        {
            this.data = new DataLoader(ref users, ref ratings, ref restaurants);
            
        }
        // email validation
        public bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        //Login 
        public User LogIn(string id, string pwd)
        {
            return data.LogIn(id, pwd);
        }
        //Registration
        public bool Registration(string Id,  string Pw, string Name, string Mail)
        {
            User u = new User(Id, Pw, Name, Mail);
            return data.Registration(u);
        }
        //checkUsername
        public bool CheckUserNameUnique(string UserID)
        {
            return data.CheckUserNameUnique(UserID);
        }
        public bool CheckEmailUnique(string email)
        {
            return data.CheckEmailUnique(email);
        }
        //--------------------------------------------------------------------------------------- LOGIN
        //Étterem kiiras fileba
        public bool AddRestaurant(string name, string address)
        {
            Restaurant restaurant = new Restaurant(name,address);
            return data.WriteNewRestaurantToTextFile(restaurant);
        }
        // rating kiiras fileba
        public bool AddRating(string userId, string restaurantName, int qualityOfFood, int priceValue, int service, int mood, int cleanLiness)
        {
            Rating rating = new Rating(userId, restaurantName, qualityOfFood, priceValue, service, mood, cleanLiness);
            return data.WriteNewRatingToTextFile(rating);
        }

        //get Ratings by restaurant name
        public List<Rating> GetRatingsByRestaurantName()
        {
            return data.GetRatingsByRestaurantName(Restaurant.Name);
        }

        //get restaurant names
        public List<String> getRestaurantNames()
        {
            return data.getRestaurantNames();
        }
        public void setAvergaes()
        {
            data.setAverages();
        }
        // select Restaurant
        public string selectRestaurantName(string restaurantName)
        {
            string name;
            name = data.selectRestaurant(restaurantName).Name;
            return name;

        }
        public string selectRestaurantAddress(string restaurantName)
        {
            string address;
            address = data.selectRestaurant(restaurantName).Address;
            return address;
        }

       
        public double selectRestaurantQualityAVG(string restaurantName)
        {
            double result = 0;
            result = data.selectRestaurant(restaurantName).Averages["Quality"];
            return result;
        }
        public double selectRestaurantPVAVG(string restaurantName)
        {
            double result = 0;
            result = data.selectRestaurant(restaurantName).Averages["PriceValue"];
            return result;
        }
        public double selectRestaurantServiceAVG(string restaurantName)
        {
            double result = 0;
            result = data.selectRestaurant(restaurantName).Averages["Service"];
            return result;
        }
        public double selectRestaurantMoodAVG(string restaurantName)
        {
            double result = 0;
            result = data.selectRestaurant(restaurantName).Averages["Mood"];
            return result;
        }
        public double selectRestaurantCleanAVG(string restaurantName)
        {
            double result = 0;
            result = data.selectRestaurant(restaurantName).Averages["Clean"];
            return result;
        }
        //--------------------------------------------------------------------------Átlagok
        /*
        // print lists to file
        public bool PrintAllUsers()
        {
            return data.PrintAllUsers();
        }
        public bool PrintAllRestaurants()
        {
            return data.PrintAllRestaurants();
        }
        public bool PrintAllRatings()
        {
            return data.PrintAllRatings();
        }
        */
    }
}

