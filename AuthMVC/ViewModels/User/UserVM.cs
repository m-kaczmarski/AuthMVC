using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AuthMVC.Models;
using System.ComponentModel.DataAnnotations;

namespace AuthMVC.ViewModels.User
{
    public class UserVM : AuthMVC.Models.User
    {
        public UserVM()
        {
            
        }

        public UserVM(AuthMVC.Models.User u)
        {
            userID = u.userID;
            firstName = u.firstName;
            lastName = u.lastName;
            age = u.age;
        }
        [Display(Name = "Nazwisko i imię")]
        public string name
        {
            get
            {
                return lastName + "" + firstName;
            }
        }
        public string colorAge
        {
            get
            {
                if (age < 18)
                {
                    return "yellow";
                }
                return "white";
            }
        }
    }
}