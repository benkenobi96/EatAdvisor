using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EatAdvisor.DB
{
    static internal class DBPaths
    {
        public static string ratingsDataFile =
        System.IO.Path.Combine(System.IO.Path.GetFullPath(@"..\..\"), "Files") +
        ("\\ratings.txt");

        public static string usersDataFile =
        System.IO.Path.Combine(System.IO.Path.GetFullPath(@"..\..\"), "Files") +
        ("\\users.txt");

        public static string restaurantsDataFile =
        System.IO.Path.Combine(System.IO.Path.GetFullPath(@"..\..\"), "Files") +
        ("\\restaurants.txt");
    }
}
 
