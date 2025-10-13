using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClinicaDermaCenter2025.Models.Inventario
{
    public class Proveedor
    {
        public int Id { get; set; }
        [Required, MaxLength(120)] public string Nombre { get; set; } = "";
        [MaxLength(200)] public string? Direccion { get; set; }
        [MaxLength(30)] public string? Telefono { get; set; }
        [MaxLength(120), EmailAddress] public string? Email { get; set; }
        public bool Activo { get; set; } = true;

    }
}
