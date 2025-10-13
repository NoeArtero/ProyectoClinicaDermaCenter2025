using ProyectoClinicaDermaCenter2025.Models.Agenda_Atencion;
using ProyectoClinicaDermaCenter2025.Models.Comun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClinicaDermaCenter2025.Interfaces.Servicios
{
    public interface ICitaServicio
    {
        Resultado<int> Crear(Cita c);
        Resultado Reprogramar(int citaId, DateTime nuevoInicio, DateTime nuevoFin);
        Resultado Cancelar(int citaId, string? motivo);
        Resultado<List<Cita>> Listar(CitaFiltro filtro);
    }
}
