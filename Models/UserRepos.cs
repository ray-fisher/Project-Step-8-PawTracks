using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Step_8_PawTracks.Models
{
    public class UserRepos
    {
        // Fields & Properties

        private static List<Registration> users
         = new List<Registration>();

        // Constructors // 

        // Methods //
    
        public static void AddUser(Registration user)
        {
            users.Add(user);
        }

        public static IEnumerable<Registration> Users
           => users;

        public static List<Registration> Getusers()
        {
            return users;
        }

        // public static void ResetPass(ForgotPassword pw)
        // {
        //     users.Reset(pw);
        // }
        // public static List<Registration> Getusers()
        // { 
        //     
        // }
    }
}
