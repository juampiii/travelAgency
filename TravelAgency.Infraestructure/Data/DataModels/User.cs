using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelAgencyWebApplication.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// Nombre de viajero
        /// </summary>
        [Required]
        public string FirstName { get; set; }
        /// <summary>
        /// Apellido de viajero
        /// </summary>
        [Required]
        public string Surname { get; set; }
        /// <summary>
        /// Nombre de usuario del viajero
        /// </summary>
        [Required]
        public string UserName { get; set; }
        /// <summary>
        /// Contraseña del viajero
        /// </summary>
        [Required]
        public string Password { get; set; }

        public User()
        {
        }

    }
}