using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TravelAgencyWebApplication.Models
{
    public class Travel
    {
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// Ciudad de origen del viaje
        /// </summary>
        [Column("Origen", TypeName="ntext"), MaxLength(20), Required]
        public string Origin { get; set; }
        /// <summary>
        /// Hora de salida
        /// </summary>
        public DateTime DepartureTime { get; set; }
        /// <summary>
        /// Ciudad de destino del viaje
        /// </summary>
        [Column("Destination", TypeName = "ntext"), MaxLength(20), Required]
        public string Destination { get; set; }
        /// <summary>
        /// Hora de vuelta
        /// </summary>
        public DateTime ReturnTime { get; set; }
        /// <summary>
        /// Comentarios
        /// </summary>
        [Column("Comments", TypeName = "ntext"), MaxLength(200), Required]
        public string Comments { get; set; }
        /// <summary>
        /// Marca de favorito
        /// </summary>
        public Boolean Favourite { get; set; }
        /// <summary>
        /// Precio del viaje
        /// </summary>
        [Required]
        public Double Price { get; set; }
        /// <summary>
        /// Client ID
        /// </summary>
        public int TravellerId { get; set; }
        /// <summary>
        /// Client who buy this trip
        /// </summary>
        [ForeignKey("TravellerId")]
        public virtual Traveller Traveller { get; set; }
        /// <summary>
        /// Insurance identificator
        /// </summary>
        public int? InsuranceId { get; set; }
        /// <summary>
        /// Insurance element
        /// </summary>
        [ForeignKey("InsuranceId")]
        public virtual Insurance Insurance { get; set; }
        /// <summary>
        /// Seller Id
        /// </summary>
        public int? SellerId { get; set; }
        /// <summary>
        /// Seller element
        /// </summary>
        [ForeignKey("SellerId")]
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