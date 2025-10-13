using ProyectoClinicaDermaCenter2025.Models.Comun;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClinicaDermaCenter2025.Models.Facturacion
{
    public class Pago
    {
        public int Id { get; set; }
        public int FacturaId { get; set; }

        public DateTime FechaPago { get; set; } = DateTime.Now;
        [Range(0.01, 999999)] public decimal Monto { get; set; }

        public MetodoPago Metodo { get; set; } = MetodoPago.Efectivo;
        [MaxLength(80)] public string? Referencia { get; set; } // anotaciones extras como transaccion o algo así.

    }
}
