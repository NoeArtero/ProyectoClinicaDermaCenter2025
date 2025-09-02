using ProyectoClinicaDermaCenter2025.Interfaces.Repositorios;
using ProyectoClinicaDermaCenter2025.Models.Pacientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProyectoClinicaDermaCenter2025.Models.stubs
{
    public class PacienteRepositoryStub : IPacienteRepositorio
    {
        private readonly List<(int Id, Paciente Entidad)> _registros = new();
        private readonly List<(int PacienteId, int AseguradoraId)> _polizas = new();
        private int _ultimoId = 0;
        public PacienteRepositoryStub()
        {
            var p1 = new Paciente();
            SetPropSiExiste(p1, "Nombre", "Ana López");
            SetPropSiExiste(p1, "Nombres", "Ana");
            SetPropSiExiste(p1, "Apellidos", "López");
            SetPropSiExiste(p1, "Documento", "DUI-001");

            var p2 = new Paciente();
            SetPropSiExiste(p2, "Nombre", "Carlos Pérez");
            SetPropSiExiste(p2, "Nombres", "Carlos");
            SetPropSiExiste(p2, "Apellidos", "Pérez");
            SetPropSiExiste(p2, "Documento", "DUI-002");

            var id1 = crear(p1);
            var id2 = crear(p2);

            _polizas.Add((id1, 10));
            _polizas.Add((id2, 20));
        }


        public IEnumerable<Paciente> Listar(string filtro = null)
        {
            var lista = _registros.Select(r => r.Entidad);
            if (string.IsNullOrWhiteSpace(filtro)) return lista;

            return lista.Where(p =>
            {
                var nombre = GetStringProp(p, "Nombre")
                             ?? GetStringProp(p, "Nombres")
                             ?? GetStringProp(p, "NombreCompleto");
                return (nombre ?? string.Empty).IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0;
            });
        }

        public Paciente ObtenerPorId(int id)
            => _registros.FirstOrDefault(r => r.Id == id).Entidad;

        public Paciente BuscarPorDocumento(string numeroDocumento)
        {
            if (string.IsNullOrWhiteSpace(numeroDocumento)) return null;

            return _registros.Select(r => r.Entidad).FirstOrDefault(p =>
            {
                var doc = GetStringProp(p, "Documento")
                          ?? GetStringProp(p, "DUI")
                          ?? GetStringProp(p, "Nit")
                          ?? GetStringProp(p, "NIT");
                return string.Equals(doc, numeroDocumento, StringComparison.OrdinalIgnoreCase);
            });
        }

        public IEnumerable<Paciente> BuscarPorAseguradora(int AseguradoraId)
        {
            var ids = _polizas
                .Where(x => x.AseguradoraId == AseguradoraId)
                .Select(x => x.PacienteId)
                .ToHashSet();

            return _registros.Where(r => ids.Contains(r.Id)).Select(r => r.Entidad);
        }

        public int crear(Paciente paciente)
        {
            if (paciente == null) return 0;

            var id = ++_ultimoId;

            SetPropSiExiste(paciente, "Id", id);

            _registros.Add((id, paciente));
            return id;
        }

        public bool editar(Paciente paciente)
        {
            if (paciente == null) return false;

            var idObj = GetProp(paciente, "Id");
            if (idObj is not int id) return false;

            var idx = _registros.FindIndex(r => r.Id == id);
            if (idx < 0) return false;

            _registros[idx] = (id, paciente);
            return true;
        }

        public bool eliminar(int id)
        {
            var removed = _registros.RemoveAll(r => r.Id == id) > 0;
            if (removed) _polizas.RemoveAll(p => p.PacienteId == id);
            return removed;
        }

        private static void SetPropSiExiste(object obj, string propName, object value)
        {
            var p = obj.GetType().GetProperty(propName);
            if (p != null && p.CanWrite) p.SetValue(obj, value);
        }

        private static object GetProp(object obj, string propName)
            => obj.GetType().GetProperty(propName)?.GetValue(obj);

        private static string GetStringProp(object obj, string propName)
            => GetProp(obj, propName)?.ToString();
    }
}

