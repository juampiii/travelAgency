using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TravelAgencyWebApplication.Models
{
    [Table("Sellers")]
    public class Seller:User
    {
        [Required]
        public string SellerCode { get; set; }
        /// <summary>
        /// List of Seller's Clients
        /// </summary>
        public virtual ICollection<Traveller> Travellers { get; set; }
        /// <summary>
        /// List of sells.
        /// </summary>
        public virtual ICollection<Travel> Travels { get; set; }
        public Seller():base()
        {
            this.SellerCode = String.Empty;
        }
    }
}