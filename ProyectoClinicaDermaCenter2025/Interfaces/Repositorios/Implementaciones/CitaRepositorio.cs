using Microsoft.Data.SqlClient;
using ProyectoClinicaDermaCenter2025.ConexionDB;
using ProyectoClinicaDermaCenter2025.Interfaces.Repositorios;
using ProyectoClinicaDermaCenter2025.Models.Agenda_Atencion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClinicaDermaCenter2025.Interfaces.Repositorios.Implementaciones
{

    public class CitaRepositorio : IcitaRepositorio
    {
        private string Cs => Conexion.AppConnectionString
            ?? throw new InvalidOperationException("Conexion.AppConnectionString no inicializada.");

        public int Crear(Cita c)
        {
            using var cn = new SqlConnection(Cs);
            using var cmd = new SqlCommand("sp_Cita_Crear", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PacienteId", c.PacienteId);
            cmd.Parameters.AddWithValue("@EmpleadoId", c.EmpleadoId);
            cmd.Parameters.AddWithValue("@Inicio", c.FechaHoraInicio);
            cmd.Parameters.AddWithValue("@Fin", c.FechaHoraFin);

            var pOut = new SqlParameter("@NuevoId", SqlDbType.Int) { Direction = ParameterDirection.Output };
            cmd.Parameters.Add(pOut);

            cn.Open();
            cmd.ExecuteNonQuery();
            return (int)pOut.Value;
        }

        public void Reprogramar(int citaId, DateTime nuevoInicio, DateTime nuevoFin)
        {
            using var cn = new SqlConnection(Cs);
            using var cmd = new SqlCommand("sp_Cita_Reprogramar", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CitaId", citaId);
            cmd.Parameters.AddWithValue("@NuevoInicio", nuevoInicio);
            cmd.Parameters.AddWithValue("@NuevoFin", nuevoFin);
            cn.Open();
            cmd.ExecuteNonQuery();
        }

        public void Cancelar(int citaId, string? motivo)
        {
            using var cn = new SqlConnection(Cs);
            using var cmd = new SqlCommand("sp_Cita_Cancelar", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CitaId", citaId);
            cn.Open();
            cmd.ExecuteNonQuery();
        }

        public List<Cita> Listar(CitaFiltro f)
        {
            var lista = new List<Cita>();
            using var cn = new SqlConnection(Cs);
            using var cmd = new SqlCommand("sp_Cita_Listar", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PacienteId", (object?)f.PacienteId ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@EmpleadoId", (object?)f.EmpleadoId ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Desde", (object?)f.Desde ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Hasta", (object?)f.Hasta ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Estado", (object?)f.Estado ?? DBNull.Value);
            cn.Open();
            using var rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                lista.Add(new Cita
                {
                    Id = rd.GetInt32(rd.GetOrdinal("Id")),
                    PacienteId = rd.GetInt32(rd.GetOrdinal("PacienteId")),
                    EmpleadoId = rd.GetInt32(rd.GetOrdinal("EmpleadoId")),
                    FechaHoraInicio = rd.GetDateTime(rd.GetOrdinal("FechaHoraInicio")),
                    FechaHoraFin = rd.GetDateTime(rd.GetOrdinal("FechaHoraFin")),
                    Estado = (Models.Comun.EstadoCita)rd.GetInt32(rd.GetOrdinal("Estado")),
                    FechaRegistro = rd.GetDateTime(rd.GetOrdinal("FechaRegistro"))
                });
            }
            return lista;
        }

        public bool ExisteSolape(int empleadoId, DateTime inicio, DateTime fin, int? excluirCitaId = null)
        {
            
            const string sql = @"
SELECT COUNT(1)
FROM Cita WITH (NOLOCK)
WHERE EmpleadoId = @EmpleadoId
  AND Estado NOT IN (2) -- 2=Cancelada
  AND (@Inicio < FechaHoraFin) AND (@Fin > FechaHoraInicio)
  AND (@Excluir IS NULL OR Id <> @Excluir);";
            using var cn = new SqlConnection(Cs);
            using var cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@EmpleadoId", empleadoId);
            cmd.Parameters.AddWithValue("@Inicio", inicio);
            cmd.Parameters.AddWithValue("@Fin", fin);
            cmd.Parameters.AddWithValue("@Excluir", (object?)excluirCitaId ?? DBNull.Value);
            cn.Open();
            var count = (int)cmd.ExecuteScalar();
            return count > 0;
        }

       
    }

}
