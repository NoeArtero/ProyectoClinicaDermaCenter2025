using ProyectoClinicaDermaCenter2025.Models.Agenda_Atencion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClinicaDermaCenter2025.Interfaces.Repositorios
{
    public interface IAtencionRepositorio
    {
        IEnumerable<Atencion> ListarPorRango(DateTime desde, DateTime hasta, int? medicoId = null,
            int? pacienteId = null); 
        Atencion ObtenerPorId(int id);
        int Agregar(Atencion atencion);
        bool Editar(Atencion atencion);
        bool Eliminar(int id);
    }
}
