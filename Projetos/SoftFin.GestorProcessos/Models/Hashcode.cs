﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SoftFin.GestorProcessos.Models
{
    public class Hashcode
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Codigo { get; set; }
        [MaxLength(15)]
        public string ValorPadrao { get; set; }
    }
}