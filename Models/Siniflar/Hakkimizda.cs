﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProje.Models.Siniflar
{
    public class Hakkimizda
    {
        [Key]
        public int ID { get; set; } 
        public string ResimURL { get; set; }
        public string Aciklama { get; set; }
    }
}