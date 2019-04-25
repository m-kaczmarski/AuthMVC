using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using AuthMVC.Models;
using AuthMVC.ViewModels.Authentication;

namespace AuthMVC.DAL
{
    public class DB :DbContext
    {
        public DB() : base("gr2")
        {

        }

        public DbSet<User> userDB { get; set; }

        public DbSet<LoginVM> adminsDB { get; set; }


    }
}