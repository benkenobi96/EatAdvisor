using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EatAdvisor.Class_models
{
    public class Rating
    {
        private string userId;
        private string restaurantName;
        private int qualityOfFood;
        private int priceValue;
        private int service;
        private int mood;
        private int cleanLiness;


        public Rating()
        {
            
        }

        public Rating(string userId, string restaurantName, int qualityOfFood, int priceValue, int service, int mood, int cleanLiness)
        {
            this.userId = userId;
            this.restaurantName = restaurantName;
            this.qualityOfFood = qualityOfFood;
            this.priceValue = priceValue;
            this.service = service;
            this.mood = mood;
            this.cleanLiness = cleanLiness;
        }
        public string UserId { get => userId; set => userId = value; }
        public string RestaurantName { get => restaurantName; set => restaurantName = value; }
        public int QualityOfFood { get => qualityOfFood; set => qualityOfFood = value; }
        public int PriceValue { get => priceValue; set => priceValue = value; }
        public int Service { get => service; set => service = value; }
        public int Mood { get => mood; set => mood = value; }
        public int CleanLiness { get => cleanLiness; set => cleanLiness = value; }

    }
}
