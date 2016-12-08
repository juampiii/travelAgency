using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelAgencyWebApplication.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public User()
        {
            Id = -1;
            FirstName = String.Empty;
            SurName = String.Empty;
            UserName = String.Empty;
            Password = String.Empty;
        }

    }
}