using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AuthMVC.ViewModels.User;


namespace AuthMVC.ViewModels.User
{
    public class CreateVM : UserVM
    {
        public UserVM user { get; set; }
        public string username { get; set; }
    }
}