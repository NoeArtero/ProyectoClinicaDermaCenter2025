using ProyectoClinicaDermaCenter2025.Models.Agenda_Atencion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClinicaDermaCenter2025.Interfaces.Repositorios.Implementaciones
{
    public interface IcitaRepositorio
    {
        int Crear(Cita c); 
        void Reprogramar(int citaId, DateTime nuevoInicio, DateTime nuevoFin);
        void Cancelar(int citaId, string? motivo);
        List<Cita> Listar(CitaFiltro filtro);
        bool ExisteSolape(int empleadoId, DateTime inicio, DateTime fin, int? excluirCitaId = null);

    }
}
