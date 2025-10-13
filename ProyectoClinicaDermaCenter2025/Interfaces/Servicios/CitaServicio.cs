using ProyectoClinicaDermaCenter2025.Interfaces.Repositorios.Implementaciones;
using ProyectoClinicaDermaCenter2025.Models.Agenda_Atencion;
using ProyectoClinicaDermaCenter2025.Models.Comun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClinicaDermaCenter2025.Interfaces.Servicios
{
    public class CitaServicio : ICitaServicio
    {
        private readonly IcitaRepositorio _repo;
        public CitaServicio(IcitaRepositorio repo) => _repo = repo;

        public Resultado<int> Crear(Cita c)
        {
           
            if (c.FechaHoraFin <= c.FechaHoraInicio)
                return Resultado<int>.Error("La hora fin debe ser mayor que la hora inicio.");

           
            if (_repo.ExisteSolape(c.EmpleadoId, c.FechaHoraInicio, c.FechaHoraFin))
                return Resultado<int>.Error("La cita se solapa con otra existente para ese profesional.");

       

            var id = _repo.Crear(c);
            return Resultado<int>.Exito(id, "Cita creada correctamente.");
        }

        public Resultado Reprogramar(int citaId, DateTime nuevoInicio, DateTime nuevoFin)
        {
            if (nuevoFin <= nuevoInicio)
                return Resultado.Error("La hora fin debe ser mayor que la hora inicio.");


            _repo.Reprogramar(citaId, nuevoInicio, nuevoFin);
            return Resultado.Exito("Cita reprogramada.");
        }

        public Resultado Cancelar(int citaId, string? motivo)
        {
            _repo.Cancelar(citaId, motivo);
            return Resultado.Exito("Cita cancelada.");
        }

        public Resultado<List<Cita>> Listar(CitaFiltro filtro)
        {
            var data = _repo.Listar(filtro);
            return Resultado<List<Cita>>.Exito(data);
        }
    }
}
