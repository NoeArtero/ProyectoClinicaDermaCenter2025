using ProyectoClinicaDermaCenter2025.Interfaces.Repositorios;
using ProyectoClinicaDermaCenter2025.Models.Agenda_Atencion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClinicaDermaCenter2025.Models.stubs
{
    public class CitaRepositorioSTUB : ICitaRepositorio
    {
        private readonly Dictionary<int, Cita> _map = new();
        private int _ultimoId = 0;

        public CitaRepositorioSTUB()
        {
            // Semilla: una cita para probar traslape
            var c = new Cita();
            // Intentamos escribir propiedades si existen; si no existen, igual funcionará el stub
            SetPropSiExiste(c, "PacienteId", 1);
            SetPropSiExiste(c, "MedicoId", 7);
            SetPropSiExiste(c, "Inicio", new DateTime(2025, 9, 1, 9, 0, 0));
            SetPropSiExiste(c, "Duracion", TimeSpan.FromMinutes(30));
            SetPropSiExiste(c, "ConsultorioId", null);

            var id = ++_ultimoId;
            SetPropSiExiste(c, "Id", id);
            _map[id] = c;
        }

        public IEnumerable<Cita> ListarPorRango(DateTime desde, DateTime hasta, int? medicoId = null, int? pacienteId = null)
        {
            return _map.Values.Where(c =>
            {
                var ini = GetDateTimeProp(c, "Inicio", "FechaHora", "Fecha", "FechaInicio", "HoraInicio") ?? DateTime.MinValue;
                if (!(ini >= desde && ini < hasta)) return false;

                if (medicoId.HasValue)
                {
                    var med = GetIntProp(c, "MedicoId", "IdMedico", "MedicoID", "Medico");
                    if (med != medicoId.Value) return false;
                }
                if (pacienteId.HasValue)
                {
                    var pac = GetIntProp(c, "PacienteId", "IdPaciente", "PacienteID", "Paciente");
                    if (pac != pacienteId.Value) return false;
                }
                return true;
            });
        }

        public Cita ObtenerPorId(int id)
            => _map.TryGetValue(id, out var c) ? c : null;

        public int Agregar(Cita entidad)
        {
            var id = ++_ultimoId;
            SetPropSiExiste(entidad, "Id", id);
            _map[id] = entidad;
            return id;
        }

        public bool Editar(Cita entidad)
        {
            var id = GetIntProp(entidad, "Id", "CitaId", "ID");
            if (id == null) return false;                      // si tu modelo no expone Id, el stub no puede ubicar el registro
            if (!_map.ContainsKey(id.Value)) return false;
            _map[id.Value] = entidad;
            return true;
        }

        public bool Eliminar(int id) => _map.Remove(id);

        public bool ExisteChoque(int medicoId, DateTime inicio, TimeSpan duracion, int? consultorioId = null, int? citaIdIgnorar = null)
        {
            var fin = inicio + duracion;
            foreach (var kv in _map)
            {
                var c = kv.Value;
                var id = kv.Key;

                if (citaIdIgnorar.HasValue && id == citaIdIgnorar.Value) continue;

                var med = GetIntProp(c, "MedicoId", "IdMedico", "MedicoID", "Medico") ?? -1;
                if (med != medicoId) continue;

                if (consultorioId.HasValue)
                {
                    var cons = GetIntProp(c, "ConsultorioId", "IdConsultorio", "Consultorio");
                    if (cons != consultorioId.Value) continue;
                }

                var cIni = GetDateTimeProp(c, "Inicio", "FechaHora", "Fecha", "FechaInicio", "HoraInicio") ?? DateTime.MinValue;
                var cDur = GetTimeSpanProp(c, "Duracion", "Tiempo", "DuracionMinutos") ?? TimeSpan.FromMinutes(30);
                var cFin = cIni + cDur;

                if (cIni < fin && inicio < cFin) return true;  // Regla de traslape [ini, fin)
            }
            return false;
        }

        // ---------------- Helpers de reflexión ----------------
        private static void SetPropSiExiste(object obj, string propName, object value)
        {
            var p = obj.GetType().GetProperty(propName);
            if (p == null || !p.CanWrite) return;

            // Si la propiedad es TimeSpan y llega un número (minutos), conviértelo
            if (p.PropertyType == typeof(TimeSpan) && value is int m)
                p.SetValue(obj, TimeSpan.FromMinutes(m));
            else
                p.SetValue(obj, value);
        }

        private static int? GetIntProp(object obj, params string[] names)
        {
            var t = obj.GetType();
            foreach (var n in names)
            {
                var p = t.GetProperty(n);
                if (p == null) continue;
                var v = p.GetValue(obj);
                if (v == null) return null;
                if (v is int i) return i;
                if (v is long l) return (int)l;
                if (v is short s) return (int)s;
                if (int.TryParse(v.ToString(), out var parsed)) return parsed;
            }
            return null;
        }

        private static DateTime? GetDateTimeProp(object obj, params string[] names)
        {
            var t = obj.GetType();
            foreach (var n in names)
            {
                var p = t.GetProperty(n);
                if (p == null) continue;
                var v = p.GetValue(obj);
                if (v == null) return null;
                if (v is DateTime dt) return dt;
                if (DateTime.TryParse(v.ToString(), out var parsed)) return parsed;
            }
            return null;
        }

        private static TimeSpan? GetTimeSpanProp(object obj, params string[] names)
        {
            var t = obj.GetType();
            foreach (var n in names)
            {
                var p = t.GetProperty(n);
                if (p == null) continue;
                var v = p.GetValue(obj);
                if (v == null) return null;
                if (v is TimeSpan ts) return ts;

                if (v is int i) return TimeSpan.FromMinutes(i);
                if (v is long l) return TimeSpan.FromMinutes(l);
                if (double.TryParse(v.ToString(), out var d)) return TimeSpan.FromMinutes(d);
                if (TimeSpan.TryParse(v.ToString(), out var parsedTs)) return parsedTs;
            }
            return null;
        }


    }
}
