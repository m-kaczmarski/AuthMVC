using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AuthMVC.DAL;
using AuthMVC.ViewModels.Authentication;

namespace AuthMVC.BusinessLayer
{
    public class AppBL
    {
        public bool isValidUser(LoginVM vm)
        {
            DB mDB = new DB();
            List<LoginVM> lista = mDB.adminsDB.ToList();
            string username = vm.username;
            string password = vm.hashPassword();
            if (lista.Any(x => x.password == password && x.username == username))
            {
                return true;
            }
            return false;
            
        }
        public bool isUserNameAvailable(string username)
        {
            DB mDB = new DB();
            List<LoginVM> lista = mDB.adminsDB.ToList();
            if (lista.Any(x => x.username == username))
            {
                return false;
            }
            return true;
        }
    }
}