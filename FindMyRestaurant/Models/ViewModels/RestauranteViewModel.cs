using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FindMyRestaurant.Models.ViewModels
{
    public class RestauranteViewModel
    {
        [Required(ErrorMessage = "Es Obligatorio")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Es Obligatorio")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Es Obligatorio")]
        public int IdTipoRestaurante { get; set; }

        [Required(ErrorMessage = "Es Obligatorio")]
        public int IdRangoPrecio { get; set; }

        [Required(ErrorMessage = "Es Obligatorio")]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "Es Obligatorio")]
        public int IdCiudad { get; set; }

        [Required(ErrorMessage = "Es Obligatorio")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "Es Obligatorio")]
        public string LatitudGps { get; set; }

        [Required(ErrorMessage = "Es Obligatorio")]
        public string LongitudGps { get; set; }
    }
}