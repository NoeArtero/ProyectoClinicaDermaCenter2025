using ProyectoClinicaDermaCenter2025.Models.Comun;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClinicaDermaCenter2025.Models.Inventario
{
    public class MovimientoInventario
    {
        public int Id { get; set; }
        public int InsumoId { get; set; }
        public int? LoteInsumoId { get; set; }

        public TipoMovimiento Tipo { get; set; } = TipoMovimiento.Salida;
        public int Cantidad { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Now;

        [MaxLength(200)] public string? Motivo { get; set; } // Consumo en atención (idAtencion), Compra o algo parecido.
        [MaxLength(60)] public string? Referencia { get; set; } // código externo si aplica

    }
}
