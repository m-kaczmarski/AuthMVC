using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AuthMVC.Models;
using AuthMVC.DAL;

namespace AuthMVC.Models
{
    public class UserBL
    {
        public List<User> GetUsers()
        {
            DB mDB = new DB();
            return mDB.userDB.ToList();
        }

        public void AddUser(User u)
        {
            DB mDB = new DB();
            mDB.userDB.Add(u);
            mDB.SaveChanges();
        }
    }
}