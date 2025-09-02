using ProyectoClinicaDermaCenter2025.Models.Agenda_Atencion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClinicaDermaCenter2025.Interfaces.Repositorios
{
    public  interface ICitaRepositorio
    {
        IEnumerable<Cita> ListarPorRango(DateTime Desde, DateTime Hasta, int? MedicoId = null,
            int? pacienteId = null);
        Cita ObtenerPorId(int id);
        int Agregar(Cita cita);
        bool Editar(Cita cita);
        bool Eliminar(int id);

        bool ExisteChoque(int medicoId, DateTime inicio, TimeSpan duracion,
            int? consultorioId = null, int? citaIgnorada = null);
    }
}
