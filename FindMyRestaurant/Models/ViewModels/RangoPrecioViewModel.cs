using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FindMyRestaurant.Models.ViewModels
{
    public class RangoPrecioViewModel
    {
        [Required(ErrorMessage = "Es Obligatorio")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Es Obligatorio")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Es Obligatorio")]
        public decimal PrecioMayor { get; set; }

        [Required(ErrorMessage = "Es Obligatorio")]
        public decimal PrecioMedio { get; set; }

        [Required(ErrorMessage = "Es Obligatorio")]
        public decimal PrecioMenor { get; set; }
    }
}