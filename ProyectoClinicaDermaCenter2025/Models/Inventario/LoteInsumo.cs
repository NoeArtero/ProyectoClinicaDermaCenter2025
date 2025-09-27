using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClinicaDermaCenter2025.Models.Inventario
{
    public class LoteInsumo
    {
        public int Id { get; set; }
        public int InsumoId { get; set; }
        public int? ProveedorId { get; set; }

        [Required, MaxLength(40)] public string Lote { get; set; } = "";
        public DateTime FechaEntrada { get; set; } = DateTime.Now;
        public DateTime? FechaVencimiento { get; set; }

        public int CantidadInicial { get; set; }
        public int CantidadActual { get; set; }
        public decimal PrecioUnitario { get; set; }

    }
}
