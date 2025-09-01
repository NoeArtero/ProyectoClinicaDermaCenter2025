using ProyectoClinicaDermaCenter2025.Models.Pacientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClinicaDermaCenter2025.Interfaces.Repositorios
{
    public interface IPacienteRepositorio
    {
        IEnumerable<Paciente> Listar(string filtro = null);
        Paciente ObtenerPorId(int id);
        Paciente BuscarPorDocumento(string numeroDocumento);

        IEnumerable<Paciente> BuscarPorAseguradora(int AseguradoraId);

        int crear(Paciente paciente);   
        bool editar(Paciente paciente); 
        bool eliminar(int id);
    }
}
