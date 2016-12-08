using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelAgencyWebApplication.Models
{
    public class Traveller: User
    {
        /// <summary>
        /// CLient's Number Card
        /// </summary>
        public string CardNumber { get; set; }
        /// <summary>
        /// Client's phone number
        /// </summary>
        public string PhoneNumber { get; set; }
        /// <summary>
        /// Client's Adress
        /// </summary>
        public string Adress { get; set; }
        /// <summary>
        /// Number of point accumulated in the Traveller account. 
        /// For each travel, Point = (int) Travel.price
        /// </summary>
        public int Points { get; set; }
        /// <summary>
        /// List of Client Sellers
        /// </summary>
        public virtual ICollection<Seller> Sellers { get; set; }
        /// <summary>
        /// History of client's travels
        /// </summary>
        public virtual ICollection<Travel> Travels { get; set; }

        public Traveller():base()
        {
            this.CardNumber = String.Empty;
            this.PhoneNumber = String.Empty;
            this.Adress = String.Empty;
            this.Points = 0;
        }
    }
}