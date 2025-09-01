using ProyectoClinicaDermaCenter2025.Models.Inventario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClinicaDermaCenter2025.Interfaces.Repositorios
{
    public interface IProveedorRepositorio
    {
        IEnumerable<Proveedor> Listar(string filtro = null);
        Proveedor ObtenerPorId(int id);
        int Agregar(Proveedor proveedor);
        bool Actualizar(Proveedor proveedor);
        bool Eliminar(int id);
    }
}
