using ProyectoClinicaDermaCenter2025.Models.Agenda_Atencion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClinicaDermaCenter2025.Interfaces.Repositorios
{
    public interface IServicioRepositorio
    {
        IEnumerable<Servicio> listar(string filtro = null, bool? soloActivos = null);
        Servicio ObtenerPorId(int id);
        int Agregar(Servicio servicio);
        bool Editar(Servicio servicio);
        bool Eliminar(int id);
    }
}
