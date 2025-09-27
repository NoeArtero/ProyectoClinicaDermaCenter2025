using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClinicaDermaCenter2025.Models.Comun
{
    public enum EstadoCita { Programada = 0, Atendida = 1, Cancelada = 2, NoAsistio = 3, Reprogramada = 4 }
    public enum MetodoPago { Efectivo = 0, Tarjeta = 1, Transferencia = 2, Seguro = 3 }
    public enum EstadoFactura { Pendiente = 0, Parcial = 1, Pagada = 2, Anulada = 3 }
    public enum TipoMovimiento { Entrada = 0, Salida = 1, Ajuste = 2 }
}
