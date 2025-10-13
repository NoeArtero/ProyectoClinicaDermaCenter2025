using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClinicaDermaCenter2025.Models.Agenda_Atencion
{
    public class AtencionServicio
    {
        public int Id { get; set; }
        public int AtencionId { get; set; }
        public int ServicioId { get; set; }

        [Range(1, 9999)] public int Cantidad { get; set; } = 1;
        [Range(0, 999999)] public decimal PrecioUnitario { get; set; }
        public decimal Subtotal => PrecioUnitario * Cantidad;

    }
}
