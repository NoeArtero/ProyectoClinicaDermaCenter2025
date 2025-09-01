using ProyectoClinicaDermaCenter2025.Models.RecursosHumanos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClinicaDermaCenter2025.Interfaces.Repositorios
{
    public interface IEmpleadoRepositorio
    {
        IEnumerable<Empleado> Listar(string filtro = null,
            bool? SoloMedicos = null);
        Empleado ObtenerPorId(int id);
        int Crear(Empleado empleado);
        bool Editar(Empleado empleado);
        bool Eliminar(int id);
    }
}
