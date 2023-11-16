using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_Project_106._2
{
         class User
        {
            public  String username;
            public  String password;


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

    static class globals
    {
        public static User globalUser = null;
    }

}
