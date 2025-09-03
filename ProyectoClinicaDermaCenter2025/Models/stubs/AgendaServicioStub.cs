using ProyectoClinicaDermaCenter2025.Interfaces.Repositorios;
using ProyectoClinicaDermaCenter2025.Interfaces.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClinicaDermaCenter2025.Models.stubs
{
    public class AgendaServicioStub
    {
        public class AgendaServiceStub : IAgendaServicio
        {
            private readonly ICitaRepositorio _citas;
            public AgendaServiceStub(ICitaRepositorio citas) => _citas = citas;

            public bool validarDisponibilidad(int medicoId, DateTime inicio, TimeSpan duracion, int? consultorioId = null, int? citaIdIgnorar = null)
            {
                var hayTraslape = _citas.ExisteChoque(medicoId, inicio, duracion, consultorioId, citaIdIgnorar);
                return !hayTraslape; 
            }
        }
    }
}
