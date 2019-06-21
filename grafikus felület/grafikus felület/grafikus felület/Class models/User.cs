using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EatAdvisor.Class_models
{
    public class User
    {
        private string userId;
        private string pwd;
        private string name;
        private string email;

        public User()
        {

        }

        public User(string userId, string pwd, string name, string email )
        {
            this.userId = userId;
            this.pwd = pwd;
            this.name = name;
            this.email = email;
        }

        public string UserId { get => userId; set => userId = value; }
        public string Pwd { get => pwd; set => pwd = value; }
        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
    }
}
