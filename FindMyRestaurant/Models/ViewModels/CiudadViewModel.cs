using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FindMyRestaurant.Models.ViewModels
{
    public class CiudadViewModel
    {
        [Required(ErrorMessage = "Es Obligatorio")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Es Obligatorio")]
        public string Nombre { get; set; }
    }
}