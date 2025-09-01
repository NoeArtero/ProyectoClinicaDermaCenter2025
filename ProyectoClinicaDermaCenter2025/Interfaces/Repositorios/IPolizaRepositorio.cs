using ProyectoClinicaDermaCenter2025.Models.Aseguradoras_Polizas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClinicaDermaCenter2025.Interfaces.Repositorios
{
    public interface IPolizaRepositorio
    {
        IEnumerable<PolizaPaciente> Listar(int PacienteId);
        PolizaPaciente ObtenerPorId(int id);
        int Crear(PolizaPaciente poliza);
        bool Actualizar(PolizaPaciente poliza);
        bool Eliminar(int id);
    }
}
