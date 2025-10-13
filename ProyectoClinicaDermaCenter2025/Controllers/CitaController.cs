using ProyectoClinicaDermaCenter2025.Interfaces.Servicios;
using ProyectoClinicaDermaCenter2025.Models.Agenda_Atencion;
using ProyectoClinicaDermaCenter2025.Models.Comun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClinicaDermaCenter2025.Controllers
{
    /*este es súper importante reyes porque es el que
     asegura que no haya duplicidad*/
    public class CitaController
    {

        private readonly ICitaServicio _servicio;
        public CitaController(ICitaServicio servicio) => _servicio = servicio;

        public Resultado<List<Cita>> Listar(CitaFiltro filtro) => _servicio.Listar(filtro);

        public Resultado<int> Crear(Cita c) => _servicio.Crear(c);

        public Resultado Reprogramar(int citaId, DateTime nuevoInicio, DateTime nuevoFin) =>
            _servicio.Reprogramar(citaId, nuevoInicio, nuevoFin);

        public Resultado Cancelar(int citaId, string? motivo) =>
            _servicio.Cancelar(citaId, motivo);
    }
}
