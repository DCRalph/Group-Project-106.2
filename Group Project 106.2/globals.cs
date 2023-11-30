using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_Project_106._2
{
        class User
        {
        public String username;
        public String password;
        public String city;
        public int vaccinated;
        public int isAdmin;


        public Boolean match(User other)
        {
            if (other == null)
                return false;

            if (username == null || password == null)
                return false;

            if (username.Equals(other.username) && password.Equals(other.password)) return true;

            return false;
        }

    }

    class Appoitment
    {
        public String name;
        public String email;
        public String phone;
        public String gender;
    }

    static class globals
    {
        public static User globalUser = null;

        public static string databaseFileName = "db.sqlite";
        public static string source = $"Data Source={System.IO.Path.Combine(Directory.GetCurrentDirectory(), databaseFileName)}";


    }

}
