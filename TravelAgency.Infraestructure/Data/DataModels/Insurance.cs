using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelAgencyWebApplication.Models
{
    public class Insurance
    {
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// Referencia del seguro
        /// </summary>
        public String ExternalCode { get; set; }
        public Insurance()
        {
            this.Id = -1;
            this.ExternalCode = String.Empty;
        }
    }
}