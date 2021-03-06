﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FindMyRestaurant.Models.ViewModels
{
    public class TransporteViewModel
    {
        [Required(ErrorMessage = "Es Obligatorio")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Es Obligatorio")]
        public string Nombre { get; set; }
    }
}