using ProyectoClinicaDermaCenter2025.Models.Seguridad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClinicaDermaCenter2025.Interfaces.Repositorios
{
    public interface IRolRepositorio
    {
        IEnumerable<Rol> Listar(string filtro = null);
        Rol ObtenerPorId(int id);
        int crear(Rol rol);
        bool Editar(Rol rol);
        bool Eliminar(int id);
    }
}
