using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClinicaDermaCenter2025.Models.Inventario
{
    public class Insumo
    {
        public int Id { get; set; }
        [Required, MaxLength(120)] public string Nombre { get; set; } = "";
        [MaxLength(200)] public string? Descripcion { get; set; }
        [MaxLength(20)] public string? UnidadMedida { get; set; } // ml, mg, etc.
        public int StockMinimo { get; set; } = 0;
        public bool Activo { get; set; } = true;

    }
}
