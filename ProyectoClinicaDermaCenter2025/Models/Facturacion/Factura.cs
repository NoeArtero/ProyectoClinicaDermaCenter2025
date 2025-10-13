using ProyectoClinicaDermaCenter2025.Models.Comun;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClinicaDermaCenter2025.Models.Facturacion
{
    public class Factura
    {
        public int Id { get; set; }
        public DateTime FechaEmision { get; set; } = DateTime.Now;

        public int PacienteId { get; set; }
        public int? AtencionId { get; set; } 

        [Range(0, 999999)] public decimal MontoTotal { get; set; }
        public EstadoFactura Estado { get; set; } = EstadoFactura.Pendiente;

        [MaxLength(60)] public string? NumeroDocumento { get; set; } 

    }
}
