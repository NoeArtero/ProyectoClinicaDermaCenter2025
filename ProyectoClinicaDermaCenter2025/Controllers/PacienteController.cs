using ProyectoClinicaDermaCenter2025.Interfaces.Repositorios;
using ProyectoClinicaDermaCenter2025.Models.Pacientes;
using ProyectoClinicaDermaCenter2025.Recursos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClinicaDermaCenter2025.Controllers
{
    public class PacienteController
    {
        private readonly IPacienteRepositorio _repo;
        public PacienteController(IPacienteRepositorio repo) => _repo = repo;

        public IEnumerable<Paciente> Listar(string filtro = null)
        {
            try { return _repo.Listar(filtro); }
            catch (Exception ex) { mensaje.MostrarError("Error", ex.ToString()); 
                return Array.Empty<Paciente>(); }
        }

        public Paciente Obtener(int id)
        {
            try { return _repo.ObtenerPorId(id); }
            catch (Exception ex) { mensaje.MostrarError("Error", 
                ex.ToString()); return null; }
        }

        public Paciente BuscarPorDocumento(string doc)
        {
            try { return _repo.BuscarPorDocumento(doc); }
            catch (Exception ex) { mensaje.MostrarError("Error", 
                ex.ToString()); return null; }
        }

        public IEnumerable<Paciente> BuscarPorAseguradora(int aseguradoraId)
        {
            try { return _repo.BuscarPorAseguradora(aseguradoraId); }
            catch (Exception ex) { mensaje.MostrarError("Error", ex.ToString());
                return Array.Empty<Paciente>(); }
        }

        public (bool ok, string msg, int id) crear(Paciente p)
        {
            try
            {
                var id = _repo.crear(p); 
                return (id > 0, id > 0 ? "Paciente creado" : "No se pudo crear", id);
            }
            catch (Exception ex)
            {
                mensaje.MostrarError("Error", ex.ToString());
                return (false, ex.Message, 0);   
            }
        }

        public (bool ok, string msg) Editar(Paciente p)
        {
            try { return (_repo.editar(p), "Cambios guardados"); }
            catch (Exception ex) { mensaje.MostrarError("Error",
                ex.ToString()); return (false, ex.Message); }
        }

        public (bool ok, string msg) Eliminar(int id)
        {
            try { return (_repo.eliminar(id), "Eliminado"); }
            catch (Exception ex) { mensaje.MostrarError("Error", ex.ToString());
                return (false, ex.Message); }
        }
    }
}
