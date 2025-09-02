using ProyectoClinicaDermaCenter2025.Models.Facturacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClinicaDermaCenter2025.Interfaces.Repositorios
{
    public interface IPagoRepositorio
    {
        IEnumerable<Pago> ListarPorFactura(int facturaId);
        Pago ObtenerPorId(int id);
        int Agregar(Pago pago);
        bool Eliminar(Pago pago);
    }
}
