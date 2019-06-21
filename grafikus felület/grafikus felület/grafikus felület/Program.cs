using EatAdvisor.Class_models;
using EatAdvisor.DB;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EatAdvisor
{
    static class Program
    {

        private static Controller control;

        private static List<User> users = new List<User>();
        private static List<Rating> ratings = new List<Rating>();
        private static List<Restaurant> restaurants = new List<Restaurant>();

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string usersFile = DBPaths.usersDataFile;
            string ratingsFile = DBPaths.ratingsDataFile;
            string restaurantsFile = DBPaths.restaurantsDataFile;

            if (File.Exists(usersFile))
            {
                using (StreamReader r = new StreamReader(usersFile))
                {
                    string s = r.ReadLine();
                    while (s != null)
                    {
                        string[] tokens = s.Split(';');
                        User u = new User();
                        u.UserId = tokens[0];
                        u.Pwd = tokens[1];
                        u.Name = tokens[2];
                        u.Email = tokens[3];
                        users.Add(u);
                        s = r.ReadLine();
                    }
                }
            }
            if (File.Exists(restaurantsFile))
            {
                using (StreamReader r = new StreamReader(restaurantsFile))
                {
                    string s = r.ReadLine();
                    while (s != null)
                    {
                        string[] tokens = s.Split(';');
                        Restaurant a = new Restaurant();
                        a.Name = tokens[0];
                        a.Address = tokens[1];
                        restaurants.Add(a);
                        s = r.ReadLine();
                    }
                }
            }
            if (File.Exists(ratingsFile))
            {
                using (StreamReader r = new StreamReader(ratingsFile))
                {
                    string s = r.ReadLine();
                    while (s != null)
                    {
                        string[] tokens = s.Split(';');
                        Rating a = new Rating();
                        a.UserId = tokens[0];
                        a.RestaurantName = tokens[1];
                        a.QualityOfFood = Convert.ToInt32(tokens[2]);
                        a.PriceValue = Convert.ToInt32(tokens[3]);
                        a.Service = Convert.ToInt32(tokens[4]);
                        a.Mood = Convert.ToInt32(tokens[5]);
                        a.CleanLiness = Convert.ToInt32(tokens[6]);
                        ratings.Add(a);
                        s = r.ReadLine();
                    }
                }
            }
                       control = new Controller(ref users, ref ratings, ref restaurants);

            Application.Run(new Bejelentkezes(control));


        }
    }
}
