using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace FindMyRestaurant.Models.ViewModels
{
    public class UsuarioViewModel
    {
        [Required(ErrorMessage = "Es Obligatorio")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Es Obligatorio")]
        public string User { get; set; }

        [Required(ErrorMessage = "Es Obligatorio")]
        public string Contraseña { get; set; }

        [Required(ErrorMessage = "Es Obligatorio")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Es Obligatorio")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Es Obligatorio")]
        public int IdTransporte { get; set; }
    }
}