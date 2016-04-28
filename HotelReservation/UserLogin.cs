using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI2
{
    public static class UserLogin
    {
        public static  string username { get; set; }
        public static  string password { get; set; }
        public static  List<string> getPassword()
        {
            List<string> allPasswords;
            using (var context = new HotelFinalProjectEntities1 ())
            {
                var key = context.Logins.Select(r =>r.Password );
                allPasswords = new List<string>(key.ToList());
            }
           
            return allPasswords;
        }
        public static List<string> getUsername()
        {
            List<string> allUserNames;
            using (var context = new HotelFinalProjectEntities1 ())
            {
                var name = context.Logins.Select(r => r.Name);
                allUserNames = new List<string>(name.ToList());
            }
           
            return allUserNames;
        }
        public static  Boolean  LoginResult()
        {
            List<string> usernames_collection = getUsername();
            List<string> passwords_collection = getPassword();
            foreach (var name in usernames_collection  )
            {
                foreach (var pass in passwords_collection )
                {
                    if (username == name && password == pass)
                    {
                        return true;
                    }
                }
                
            }
            return false;
            
        }
        public static  string  AddUser()
        {

            using (var context = new HotelFinalProjectEntities1())
            {
                var user = new Login();
                if (username == Convert.ToString("") || password == Convert.ToString(""))
                {
                    return " Name or password cannot be empty!";
                }
                else
                {
                    user.Name = username;
                    user.Password = password;
                    context.Logins.Add(user);
                    context.SaveChanges();
                }
                return " Successfully added a new log-in !";
                //user.Name = username;
                //user.Password = password;
                //context.Logins.Add(user);
                //context.SaveChanges();
            }
            
        }
    }
}
