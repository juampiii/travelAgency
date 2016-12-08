using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelAgencyWebApplication.Models
{
    public class Insurance
    {
        public int Id { get; set; }
        public String ExternalCode { get; set; }
        public Insurance()
        {
            this.Id = -1;
            this.ExternalCode = String.Empty;
        }
    }
}