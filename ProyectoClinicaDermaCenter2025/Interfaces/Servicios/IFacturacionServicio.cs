using ProyectoClinicaDermaCenter2025.Models.Facturacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClinicaDermaCenter2025.Interfaces.Servicios
{
    public interface IFacturacionServicio
    {
        decimal CalcularTotalAtencion(int atencionId);
        int GenerarFactura(int atencionId, int pacienteId, DateTime fechaEmision);
        bool RegistrarPago(int facturaId, Pago pago);
        decimal ObtenerSaldo(int facturaId);
    }
}
