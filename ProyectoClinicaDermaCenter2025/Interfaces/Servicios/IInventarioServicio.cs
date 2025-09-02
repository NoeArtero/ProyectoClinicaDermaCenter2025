using ProyectoClinicaDermaCenter2025.Models.Inventario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClinicaDermaCenter2025.Interfaces.Servicios
{
    public interface IInventarioServicio
    {
        bool DescontarPorAtencion(int atencionId);

        bool IngresoStock(LoteInsumo loteInsumo, int cantidad, decimal costeUnidad);

        int ObtenerStockDisponible(int insumoId);

        IEnumerable<LoteInsumo> ObtenerAlertaBajoStock();
    }
}
