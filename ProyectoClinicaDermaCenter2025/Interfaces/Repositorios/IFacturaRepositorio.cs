using ProyectoClinicaDermaCenter2025.Models.Facturacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClinicaDermaCenter2025.Interfaces.Repositorios
{
    public interface IFacturaRepositorio
    {
        IEnumerable<Factura> ListarPorRango(DateTime desde, DateTime hasta, int? pacienteId = null);
        Factura ObtenerPorId(int id);
        int agregar(Factura factura);   
        bool Editar(Factura factura);
        bool Eliminar(int id);

        decimal ObtenerSaldo(int facturaId);
    }
}
