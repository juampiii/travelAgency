using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelAgencyWebApplication.Models
{
    public class Travel
    {
        public int Id { get; set; }
        public string Origin { get; set; }
        public DateTime DepartureTime { get; set; }
        public string Destination { get; set; }
        public DateTime ReturnTime { get; set; }
        public string Comments { get; set; }
        public Double Price { get; set; }
        /// <summary>
        /// Client ID
        /// </summary>
        public int TravellerId { get; set; }
        /// <summary>
        /// Client who buy this trip
        /// </summary>
        public virtual Traveller Traveller { get; set; }
        /// <summary>
        /// Insurance identificator
        /// </summary>
        public int InsuranceId { get; set; }
        /// <summary>
        /// Insurance element
        /// </summary>
        public virtual Insurance Insurance { get; set; }
        /// <summary>
        /// Seller Id
        /// </summary>
        public int SellerId { get; set; }
        /// <summary>
        /// Seller element
        /// </summary>
        public virtual Seller Seller { get; set; }

        public Travel()
        {
            Id = -1;
            this.Origin = String.Empty;
            this.DepartureTime = new DateTime();
            this.Destination = String.Empty;
            this.ReturnTime = new DateTime();
            this.Comments = String.Empty;
            this.Price = 0.0;
        }
    }
}