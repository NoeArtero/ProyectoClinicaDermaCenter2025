﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClinicaDermaCenter2025.Models.Seguridad
{
    public class Rol
    {
        public int Id { get; set; }
        [Required, MaxLength(100)] public string Nombre { get; set; } = "";
        [MaxLength(100)] public string? Descripcion { get; set; } 
        public bool Activo { get; set; } = true;    
    }
}
