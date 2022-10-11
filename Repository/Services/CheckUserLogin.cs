using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace Repository.Services
{
    public class CheckUserLogin
    {
        private static readonly CheckUserLogin _checkUserLogin = new CheckUserLogin();

        public static CheckUserLogin GetCheckUserLogin()
        {
            return _checkUserLogin;
        }
        private CheckUserLogin()
        {

        }
        public User ReturnUserId(string username,string password)
        {
            var db = new ZooDbContext();
            if(username != null && password != null)
            {
                //int id = 
                //if(id != 0)
                try
                {
                    User user = db.User.Where(u => u.Name == username && u.Password == password).FirstOrDefault();
                    if(user != null)
                    {
                        return user;
                    }
                }catch(Exception ex)
                {
                    Debug.WriteLine("Exception: " + ex.Message);
                    throw;
                }


            }
            return null;
        }
       
    }
}
