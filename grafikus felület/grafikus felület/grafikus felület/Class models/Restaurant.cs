using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EatAdvisor.Class_models
{
    public class Restaurant
    {
        private string name;
        private string address;
        private Dictionary<string, double> averages;

        public Restaurant()
        {
            this.averages = new Dictionary<string, double>();
            
        }
        public Restaurant(string name, string address)
        {
            this.name = name;
            this.address = address;
            this.averages = new Dictionary<string, double>();
        }

        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public Dictionary<string, double> Averages { get => averages; set => averages = value; }
    }
}
