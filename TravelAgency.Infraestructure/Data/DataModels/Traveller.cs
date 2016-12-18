using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TravelAgencyWebApplication.Models
{
    [Table("Travellers")]
    public class Traveller: User
    {
        /// <summary>
        /// Client's Number Card
        /// </summary>
        [Required]
        public string CardNumber { get; set; }
        /// <summary>
        /// Client's phone number
        /// </summary>
        [Required, Column("PhoneNumber", TypeName = "ntext"), MaxLength(20)]
        public string PhoneNumber { get; set; }
        /// <summary>
        /// Client's Adress
        /// </summary>
        [Column("Adress", TypeName="ntext"), MaxLength(80)]
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
        /// Historial de viajes favoritos
        /// </summary>
        public virtual ICollection<Travel> TravelsFavs { get; set; }
        /// <summary>
        /// Historial de viajes adquiridos
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